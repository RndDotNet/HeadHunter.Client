using Refit;
using RndDotNet.HeadHunter.Client.Areas;
using RndDotNet.HeadHunter.Client.Authentication;
using RndDotNet.HeadHunter.Client.Industries;
using RndDotNet.HeadHunter.Client.ProfessionalRoles;
using RndDotNet.HeadHunter.Client.Vacancies;

namespace RndDotNet.HeadHunter.Client;

public class HeadHunterApiClientFactory
{
	private readonly Func<HeadHunterApiClientSettings> settingsGetter;

	private string? accessToken;

	public HeadHunterApiClientFactory(Func<HeadHunterApiClientSettings> settingsGetter)
	{
		this.settingsGetter = settingsGetter;
	}

	public async Task<IHeadHunterApiClient> Build()
	{
		var settings = settingsGetter();
		accessToken ??= settings.AccessToken ?? await RetrieveAccessToken(settings);

		var httpClient = new HttpClient
		{
			BaseAddress = new Uri(settings.BaseApiUrl),
			DefaultRequestHeaders =
			{
				{ "User-Agent", settings.UserAgentHeaderValue }, 
				{ "Authorization", $"Bearer {settings.AccessToken}" }
			}
		};
		
		var areasClient = RestService.For<IHeadHunterApiAreasClient>(httpClient);
		var industriesClient = RestService.For<IHeadHunterApiIndustriesClient>(httpClient);
		var professionalRolesClient = RestService.For<IHeadHunterApiProfessionalRolesClient>(httpClient);
		var vacanciesClient = RestService.For<IHeadHunterApiVacanciesClient>(httpClient);

		return new HeadHunterApiClient(areasClient, industriesClient, professionalRolesClient, vacanciesClient);
	}

	private static async Task<string> RetrieveAccessToken(HeadHunterApiClientSettings settings)
	{
		var authClient = RestService.For<IHeadHunterAuthClient>(settings.AuthApiUrl);
		var request = new GetAccessTokenRequest
		{
			GrantType = "client_credentials",
			ClientId = settings.ClientId,
			ClientSecret = settings.ClientSecret
		};
		var response = await authClient.GetAccessTokenAsync(request);

		return response.AccessToken;
	}
}
