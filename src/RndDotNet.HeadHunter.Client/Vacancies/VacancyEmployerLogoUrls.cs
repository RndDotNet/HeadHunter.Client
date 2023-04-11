using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Links to employer's logos of different size.
/// </summary>
public class VacancyEmployerLogoUrls
{
	/// <summary>
	/// URL of logo with minimum side size of 90px.
	/// </summary>
	[JsonPropertyName("90")]
	public string Url90px { get; set; }
	
	/// <summary>
	/// URL of logo with minimum side size of 240px.
	/// </summary>
	[JsonPropertyName("240")]
	public string Url240px { get; set; }
	
	/// <summary>
	/// URL of original size logo.
	/// </summary>
	[JsonPropertyName("original")]
	public string Original { get; set; }
}