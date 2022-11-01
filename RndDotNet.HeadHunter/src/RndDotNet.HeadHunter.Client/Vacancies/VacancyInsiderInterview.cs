using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Interview about life in the company.
/// </summary>
public class VacancyInsiderInterview
{
	/// <summary>
	/// Interview ID.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }
	
	/// <summary>
	/// Address of the page containing the interview.
	/// </summary>
	[JsonPropertyName("url")]
	public string Url { get; set; }
}
