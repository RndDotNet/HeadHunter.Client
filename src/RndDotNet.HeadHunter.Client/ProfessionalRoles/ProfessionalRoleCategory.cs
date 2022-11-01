using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.ProfessionalRoles;

public class ProfessionalRoleCategory
{
	[JsonPropertyName("id")]
	public string Id { get; set; }
	
	[JsonPropertyName("name")]
	public string Name { get; set; }
	
	[JsonPropertyName("roles")]
	public ProfessionalRole[] Roles { get; set; }
}
