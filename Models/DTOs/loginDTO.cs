using System.ComponentModel.DataAnnotations;

namespace CP_2TDSPB.Models.DTOs
{
    public class loginDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}
