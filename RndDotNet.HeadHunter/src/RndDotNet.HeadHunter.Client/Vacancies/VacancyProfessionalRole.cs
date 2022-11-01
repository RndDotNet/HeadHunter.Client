using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Professional role.
/// </summary>
public class VacancyProfessionalRole
{
	/// <summary>
	/// Professional role ID.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }
	
	/// <summary>
	/// Professional role name.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}
