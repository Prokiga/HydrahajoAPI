using System.ComponentModel.DataAnnotations;

namespace HydrahajoAPI.Models
{
    public class Component
    {
        [Key]
        public int Component_Id { get; set; }
        public string Component_Name { get; set; }
        public string Component_type { get; set; }
}
}
