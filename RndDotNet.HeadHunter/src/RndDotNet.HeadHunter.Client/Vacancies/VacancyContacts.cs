using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Contact info.
/// </summary>
public class VacancyContacts
{
	/// <summary>
	/// Name of contact person.
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; set; }
	
	/// <summary>
	/// Email of contact person.
	/// </summary>
	[JsonPropertyName("email")]
	public string? Email { get; set; }
	
	/// <summary>
	/// List of phone numbers of contact person. This list may be empty.
	/// </summary>
	[JsonPropertyName("phones")]
	public VacancyContactsPhone[] Phones { get; set; }
}
