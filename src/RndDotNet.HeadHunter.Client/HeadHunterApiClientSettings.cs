namespace RndDotNet.HeadHunter.Client;

public class HeadHunterApiClientSettings
{
	public string AuthApiUrl { get; set; } = "https://hh.ru/";
	public string BaseApiUrl { get; set; } = "https://api.hh.ru/";
	
	public string ClientId { get; set; }
	public string ClientSecret { get; set; }
	public string? AccessToken { get; set; }
	
	public string UserAgentHeaderValue { get; set; }
}
