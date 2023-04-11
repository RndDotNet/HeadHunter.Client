using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// "Want to work here" service.
/// </summary>
public class VacancyEmployerApplicantServicesTargetEmployer
{
	/// <summary>
	/// Number of current applicant's CVs with "Want to work here" service activated.
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; }
}