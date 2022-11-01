using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Vacancy type.
/// </summary>
public class VacancyType
{
	/// <summary>
	/// Vacancy type ID.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }
	
	/// <summary>
	/// Vacancy type name.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}
