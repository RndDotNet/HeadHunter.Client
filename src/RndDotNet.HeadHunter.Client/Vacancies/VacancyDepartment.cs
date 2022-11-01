using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Department on whose behalf the vacancy is uploaded (if available for the company).
/// </summary>
public class VacancyDepartment
{
	/// <summary>
	/// Department ID.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }
	
	/// <summary>
	/// Department name.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}
