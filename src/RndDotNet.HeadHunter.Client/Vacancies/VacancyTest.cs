using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Information about attached test for the job.
/// </summary>
public class VacancyTest
{
	/// <summary>
	/// If the test is mandatory for an application.
	/// </summary>
	[JsonPropertyName("required")]
	public bool Required { get; set; }
}
