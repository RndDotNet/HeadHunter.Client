using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Working time modes.
/// </summary>
public class VacancyWorkingTimeModes
{
	/// <summary>
	/// Working time modes ID.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }
	
	/// <summary>
	/// Working time modes name.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}
