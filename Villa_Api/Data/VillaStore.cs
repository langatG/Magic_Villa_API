using Villa_Api.Models.Dto;

namespace Villa_Api.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> VillaList = new List<VillaDTO>
            {
                new VillaDTO{Id = 1, Name = "LANGAT", sqft=100, Occupancy=4},
                new VillaDTO{Id = 2, Name = "EVANS", sqft=300, Occupancy=3}
            };
    }
}
