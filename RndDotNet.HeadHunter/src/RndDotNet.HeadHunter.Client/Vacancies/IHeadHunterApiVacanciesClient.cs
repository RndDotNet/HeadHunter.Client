using Refit;

namespace RndDotNet.HeadHunter.Client.Vacancies;

/// <summary>
/// Api client for vacancies.
/// </summary>
public interface IHeadHunterApiVacanciesClient
{
	/// <summary>
	/// View a vacancy.
	/// </summary>
	/// <param name="vacancyId">vacancy ID</param>
	/// <returns>Return detailed information for the selected vacancy.</returns>
	[Get("/vacancies/{vacancyId}")]
	Task<Vacancy> GetVacancy(string vacancyId);
	
	/// <summary>
	/// Search for vacancies.
	/// </summary>
	/// <returns>Return the results of vacancy search.</returns>
	[Get("/vacancies")]
	Task<GetVacanciesResponse> GetVacancies(GetVacanciesQueryParams queryParams);
}
