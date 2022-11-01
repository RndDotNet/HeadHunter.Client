using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Address.
/// </summary>
public class VacancyAddress
{
	/// <summary>
	/// City name.
	/// </summary>
	[JsonPropertyName("city")]
	public string? City { get; set; }
	
	/// <summary>
	/// Street name.
	/// </summary>
	[JsonPropertyName("street")]
	public string? Street { get; set; }
	
	/// <summary>
	/// Building number.
	/// </summary>
	[JsonPropertyName("building")]
	public string? Building { get; set; }
	
	/// <summary>
	/// Additional address info.
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; set; }
	
	/// <summary>
	/// Latitude.
	/// </summary>
	[JsonPropertyName("lat")]
	public double? Latitude { get; set; }
	
	/// <summary>
	/// Longitude.
	/// </summary>
	[JsonPropertyName("lng")]
	public double? Longitude { get; set; }
	
	/// <summary>
	/// Textual description of address.
	/// </summary>
	[JsonPropertyName("raw")]
	public string? Raw { get; set; }
}
