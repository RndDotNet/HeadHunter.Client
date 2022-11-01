using Refit;

namespace RndDotNet.HeadHunter.Client.Authentication;

internal interface IHeadHunterAuthClient
{
	[Headers("Content-Type: application/x-www-form-urlencoded")]
	[Post("/oauth/token")]
	Task<GetAccessTokenResponse> GetAccessTokenAsync([Body(BodySerializationMethod.UrlEncoded)] GetAccessTokenRequest request);
}
