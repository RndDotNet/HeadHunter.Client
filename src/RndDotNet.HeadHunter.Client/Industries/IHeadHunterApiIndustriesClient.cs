using Refit;

namespace RndDotNet.HeadHunter.Client.Industries;

public interface IHeadHunterApiIndustriesClient
{
	[Get("/industries")]
	Task<IndustryCategory[]> GetAllIndustries();
}
