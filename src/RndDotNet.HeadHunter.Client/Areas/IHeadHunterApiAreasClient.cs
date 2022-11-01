using Refit;

namespace RndDotNet.HeadHunter.Client.Areas;

public interface IHeadHunterApiAreasClient
{
	[Get("/areas")]
	Task<AreaTreeItem[]> GetAllAreas();
	
	[Get("/areas/{areaId}")]
	Task<AreaTreeItem[]> GetAreas(string areaId);
	
	[Get("/areas/countries")]
	Task<Area[]> GetAllCountries();
}
