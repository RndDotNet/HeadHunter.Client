using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Driver license category.
/// </summary>
public class VacancyDriverLicenseType
{
	/// <summary>
	/// Driving license category.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }
}
