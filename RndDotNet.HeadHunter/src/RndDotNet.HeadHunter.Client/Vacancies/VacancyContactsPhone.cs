using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Contact info phone number.
/// </summary>
public class VacancyContactsPhone
{
	/// <summary>
	/// Country code.
	/// </summary>
	[JsonPropertyName("country")]
	public string Country { get; set; }
	
	/// <summary>
	/// City code.
	/// </summary>
	[JsonPropertyName("city")]
	public string City { get; set; }
	
	/// <summary>
	/// Phone number.
	/// </summary>
	[JsonPropertyName("number")]
	public string Number { get; set; }
	
	/// <summary>
	/// Commentary.
	/// </summary>
	[JsonPropertyName("comment")]
	public string? Comment { get; set; }
}
