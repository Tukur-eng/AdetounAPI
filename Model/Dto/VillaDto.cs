using System.ComponentModel.DataAnnotations;

namespace Adetoun_VillaApi.Model.Dto
{
    public class VillaDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        
        public string Occupation { get; set; }

        public int YearOfExperience { get; set; }
       
    }
}
