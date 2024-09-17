using System.ComponentModel.DataAnnotations;

namespace CP_2TDSPB.Models.DTOs
{
    public class cadastroDTO
    {
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
