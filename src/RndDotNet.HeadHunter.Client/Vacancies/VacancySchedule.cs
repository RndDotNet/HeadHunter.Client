using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Work schedule.
/// </summary>
public class VacancySchedule
{
	/// <summary>
	/// Schedule ID.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }
	
	/// <summary>
	/// Schedule name.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}
