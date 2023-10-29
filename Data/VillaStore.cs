using Adetoun_VillaApi.Model.Dto;

namespace Adetoun_VillaApi.Data
{
    public class VillaStore
    {
        public static List<VillaDto> VillaList = new List<VillaDto>{
           new VillaDto{Id = 1, Name = "Esther", Occupation= "DotNet Developer", YearOfExperience =3},
            new VillaDto{Id = 2, Name = "Tukur", Occupation= "Angular Developer", YearOfExperience =6}
        };
    }
}
