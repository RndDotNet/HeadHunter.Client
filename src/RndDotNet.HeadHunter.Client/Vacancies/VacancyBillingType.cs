using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Vacancy billing type.
/// </summary>
public class VacancyBillingType
{
	/// <summary>
	/// ID of the vacancy billing type.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }
	
	/// <summary>
	/// Name of the vacancy billing type.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}
