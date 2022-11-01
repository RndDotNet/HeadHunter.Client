using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Required work experience.
/// </summary>
public class VacancyExperience
{
	/// <summary>
	/// Required work experience ID.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }
	
	/// <summary>
	/// Name of required work experience.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}
