using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Type of employment.
/// </summary>
public class VacancyEmployment
{
	/// <summary>
	/// Employment type ID.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }
	
	/// <summary>
	/// Employment type name.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}
