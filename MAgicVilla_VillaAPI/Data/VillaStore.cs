using MAgicVilla_VillaAPI.Models.Dto;

namespace MAgicVilla_VillaAPI.Data
{
	public static class VillaStore
	{
		public static List<VillaDTO> VillaList = new()
		{ 
			new VillaDTO() {Id=1,Name="PoolVilla", Sqft = 100, Occupancy = 4},
			new VillaDTO() {Id=2,Name="BeachVilla", Sqft = 300, Occupancy = 3}
		};
	}
}
