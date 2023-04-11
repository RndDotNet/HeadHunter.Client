using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Info on employer's company (object) or (Null-object (any or null))
/// </summary>
public class VacancyEmployer
{
	/// <summary>
	/// Link to company site.
	/// </summary>
	[JsonPropertyName("alternate_url")]
	public string? AlternateUrl { get; set; }
	
	/// <summary>
	/// Company ID.
	/// </summary>
	[JsonPropertyName("id")]
	public string? Id { get; set; }
	
	/// <summary>
	/// Company name.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
	
	/// <summary>
	/// Flag that shows whether the company has passed verification on the site.
	/// </summary>
	[JsonPropertyName("trusted")]
	public bool Trusted { get; set; }
	
	/// <summary>
	/// URL for GET request to get information about the company.
	/// </summary>
	[JsonPropertyName("url")]
	public string? Url { get; set; }
	
	/// <summary>
	/// Link to vacancy search results for the company.
	/// </summary>
	[JsonPropertyName("vacancies_url")]
	public string? VacanciesUrl { get; set; }
	
	/// <summary>
	/// Whether all vacancies of the employer are added to the list of hidden.
	/// </summary>
	[JsonPropertyName("blacklisted")]
	public bool? Blacklisted { get; set; }
	
	/// <summary>
	/// Activated applicant services related to this employer.
	/// </summary>
	[JsonPropertyName("applicant_services")]
	public VacancyEmployerApplicantServices? ApplicantServices { get; set; }
	
	/// <summary>
	/// Links to employer's logos of different size.
	/// </summary>
	[JsonPropertyName("logo_urls")]
	public VacancyEmployerLogoUrls? LogoUrls { get; set; }
}