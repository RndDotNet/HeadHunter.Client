using Refit;

namespace RndDotNet.HeadHunter.Client.ProfessionalRoles;

public interface IHeadHunterApiProfessionalRolesClient
{
	[Get("/professional_roles")]
	Task<GetAllProfessionalRolesResponse> GetAllProfessionalRoles();
}
