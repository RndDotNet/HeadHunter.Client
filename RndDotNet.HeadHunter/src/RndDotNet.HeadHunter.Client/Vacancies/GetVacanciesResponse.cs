using System.Text.Json.Serialization;

namespace RndDotNet.HeadHunter.Client.Vacancies;

public class GetVacanciesResponse
{
	[JsonPropertyName("items")]
	public Vacancy[] Items { get; set; }
	
	[JsonPropertyName("found")]
	public int Found { get; set; }
	
	[JsonPropertyName("pages")]
	public int Pages { get; set; }
	
	[JsonPropertyName("per_page")]
	public int PerPage { get; set; }
	
	[JsonPropertyName("page")]
	public int Page { get; set; }
}
