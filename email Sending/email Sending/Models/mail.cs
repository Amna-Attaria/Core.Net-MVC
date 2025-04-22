using System.ComponentModel.DataAnnotations;

namespace email_Sending.Models
{
    public class mail
    {
        [Key]

        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter you email")]
        [EmailAddress]
        [StringLength(100)]
        public string email {  get; set; }

        [Required(ErrorMessage = "Please enter you MESSAGE")]
        [StringLength(120)]
        public string message { get; set; }
    }
}
