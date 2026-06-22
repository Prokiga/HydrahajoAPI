using System.ComponentModel.DataAnnotations;

namespace HydrahajoAPI.Models
{
    public class AddComponentDTO
    {
        [MaxLength(50)]
        public string Component_Name { get; set; }
        [MaxLength(50)]
        public string Component_type { get; set; }
    }
}
