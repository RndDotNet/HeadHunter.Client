using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Key skill indicated in the vacancy.
/// </summary>
public class VacancyKeySkill
{
	/// <summary>
	/// Name of key skill.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}
