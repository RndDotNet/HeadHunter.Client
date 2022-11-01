using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.ProfessionalRoles;

public class ProfessionalRole
{
	[JsonPropertyName("id")]
	public string Id { get; set; }
	
	[JsonPropertyName("name")]
	public string Name { get; set; }
	
	[JsonPropertyName("is_default")]
	public bool IsDefault { get; set; }
	
	[JsonPropertyName("accept_incomplete_resumes")]
	public bool AcceptIncompleteResumes { get; set; }
}
