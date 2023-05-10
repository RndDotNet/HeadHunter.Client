using RndDotNet.HeadHunter.Client.Areas;
using RndDotNet.HeadHunter.Client.Employers;
using RndDotNet.HeadHunter.Client.Industries;
using RndDotNet.HeadHunter.Client.ProfessionalRoles;
using RndDotNet.HeadHunter.Client.Vacancies;

namespace RndDotNet.HeadHunter.Client;

public interface IHeadHunterApiClient
{
	IHeadHunterApiAreasClient Areas { get; }
	IHeadHunterApiIndustriesClient Industries { get; }
	IHeadHunterApiProfessionalRolesClient ProfessionalRoles { get; }
	IHeadHunterApiVacanciesClient Vacancies { get; }
	IHeadHunterApiEmployersClient Employers { get; }
}
