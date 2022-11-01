using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Industries;

public class IndustryCategory
{
	[JsonPropertyName("id")]
	public string Id { get; set; }
	
	[JsonPropertyName("name")]
	public string Name { get; set; }
	
	[JsonPropertyName("industries")]
	public Industry[] Industries { get; set; }
}
