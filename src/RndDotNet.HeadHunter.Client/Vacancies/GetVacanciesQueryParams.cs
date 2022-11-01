using Refit;

namespace RndDotNet.HeadHunter.Client.Vacancies;

public class GetVacanciesQueryParams
{
	/// <summary>
	/// Text field. The sent value is searched in the vacancy fields specified in the search_field parameter.
	/// </summary>
	[AliasAs("text")]
	public string? Text { get; set; }
	
	/// <summary>
	/// An area of search.
	/// </summary>
	[AliasAs("search_field")]
	public string? SearchField { get; set; }
	
	/// <summary>
	/// A region.
	/// </summary>
	[AliasAs("area")]
	[Query(CollectionFormat.Multi)]
	public string[]? Areas { get; set; }
	
	/// <summary>
	/// An industry of the company that posted the vacancy.
	/// </summary>
	[AliasAs("industry")]
	[Query(CollectionFormat.Multi)]
	public string[]? Industries { get; set; }
	
	/// <summary>
	/// A professional role.
	/// </summary>
	[AliasAs("professional_role")]
	[Query(CollectionFormat.Multi)]
	public string[]? ProfessionalRoles { get; set; }

	/// <summary>
	/// An area of search.
	/// </summary>
	[AliasAs("per_page")]
	public int? PerPage { get; set; } = 100;
	
	/// <summary>
	/// An area of search.
	/// </summary>
	[AliasAs("page")]
	public int? Page { get; set; }
}
