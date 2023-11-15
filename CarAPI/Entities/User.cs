using System.ComponentModel.DataAnnotations;

namespace CarAPI.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Fullname is requried")]
        [MaxLength(80)]
        public string Fullname { get; set; }
        public DateTime Birthdate { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; }
        [Required]
        public string Region { get; set; }
    }
}
