using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Activated applicant services related to this employer.
/// </summary>
public class VacancyEmployerApplicantServices
{
	/// <summary>
	/// "Want to work here" service.
	/// </summary>
	[JsonPropertyName("target_employer")]
	public VacancyEmployerApplicantServicesTargetEmployer? TargetEmployer { get; set; }
}