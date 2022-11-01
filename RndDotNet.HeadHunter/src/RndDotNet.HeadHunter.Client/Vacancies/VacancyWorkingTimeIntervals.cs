using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Working time intervals.
/// </summary>
public class VacancyWorkingTimeIntervals
{
	/// <summary>
	/// Working time intervals ID.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }
	
	/// <summary>
	/// Working time intervals name.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}
