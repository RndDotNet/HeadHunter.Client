using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Employers;

/// <summary>
/// Activated applicant services related to this employer.
/// </summary>
public class EmployerApplicantServices
{
	/// <summary>
	/// "Want to work here" service.
	/// </summary>
	[JsonPropertyName("target_employer")]
	public EmployerApplicantServicesTargetEmployer? TargetEmployer { get; set; }
}