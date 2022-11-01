using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Specialisation.
/// </summary>
public class VacancySpecialization
{
	/// <summary>
	/// Specialisation ID.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }
	
	/// <summary>
	/// Specialisation name.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
	
	/// <summary>
	/// ID of the profession that includes this specialisation.
	/// </summary>
	[JsonPropertyName("profarea_id")]
	public string ProfareaId { get; set; }
	
	/// <summary>
	/// Name of the profession that includes this specialisation.
	/// </summary>
	[JsonPropertyName("profarea_name")]
	public string ProfareaName { get; set; }
}
