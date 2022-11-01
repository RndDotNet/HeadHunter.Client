using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Industries;

public class Industry
{
	[JsonPropertyName("id")]
	public string Id { get; set; }
	
	[JsonPropertyName("name")]
	public string Name { get; set; }
}
