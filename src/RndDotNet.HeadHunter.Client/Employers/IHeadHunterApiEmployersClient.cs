using Refit;

namespace RndDotNet.HeadHunter.Client.Employers;

public interface IHeadHunterApiEmployersClient
{
	[Get("/employers/{employer_id}")]
	Task<Employer> GetEmployer(string employer_id);
}