using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Authentication;

public class GetAccessTokenResponse
{
	[JsonPropertyName("access_token")]
	public string AccessToken { get; set; }
	
	[JsonPropertyName("token_type")]
	public string TokenType { get; set; }
}
