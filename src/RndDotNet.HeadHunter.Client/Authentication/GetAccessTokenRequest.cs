using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Authentication;

public record GetAccessTokenRequest
{
	[JsonPropertyName("grant_type")]
	public string GrantType { get; set; }
	
	[JsonPropertyName("client_id")]
	public string ClientId { get; set; }
	
	[JsonPropertyName("client_secret")]
	public string ClientSecret { get; set; }
}
