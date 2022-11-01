using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Working days.
/// </summary>
public class VacancyWorkingDays
{
	/// <summary>
	/// Working days ID.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }
	
	/// <summary>
	/// Working days name.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}
