using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.ProfessionalRoles;

public class GetAllProfessionalRolesResponse
{
	[JsonPropertyName("categories")]
	public ProfessionalRoleCategory[] Categories { get; set; }
}
