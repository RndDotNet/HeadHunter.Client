using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Areas;

public class AreaTreeItem
{
	[JsonPropertyName("id")]
	public string Id { get; set; }
	
	[JsonPropertyName("name")]
	public string Name { get; set; }
	
	[JsonPropertyName("parent_id")]
	public string ParentId { get; set; }
	
	[JsonPropertyName("areas")]
	public AreaTreeItem[] Areas { get; set; }
}
