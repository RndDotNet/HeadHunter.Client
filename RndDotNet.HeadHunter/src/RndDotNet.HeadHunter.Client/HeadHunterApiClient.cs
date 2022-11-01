using RndDotNet.HeadHunter.Client.Areas;
using RndDotNet.HeadHunter.Client.Industries;
using RndDotNet.HeadHunter.Client.ProfessionalRoles;
using RndDotNet.HeadHunter.Client.Vacancies;

namespace RndDotNet.HeadHunter.Client;

public class HeadHunterApiClient : IHeadHunterApiClient
{
	public IHeadHunterApiAreasClient Areas { get; }
	public IHeadHunterApiIndustriesClient Industries { get; }
	public IHeadHunterApiProfessionalRolesClient ProfessionalRoles { get; }
	public IHeadHunterApiVacanciesClient Vacancies { get; }

	internal HeadHunterApiClient(IHeadHunterApiAreasClient areasClient,
		IHeadHunterApiIndustriesClient industriesClient, 
		IHeadHunterApiProfessionalRolesClient professionalRoles, 
		IHeadHunterApiVacanciesClient vacancies)
	{
		Areas = areasClient;
		Industries = industriesClient;
		ProfessionalRoles = professionalRoles;
		Vacancies = vacancies;
	}
}
