using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Employers;

/// <summary>
/// "Want to work here" service.
/// </summary>
public class EmployerApplicantServicesTargetEmployer
{
	/// <summary>
	/// Number of current applicant's CVs with "Want to work here" service activated.
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; }
}