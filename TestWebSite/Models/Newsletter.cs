using System.ComponentModel.DataAnnotations;

namespace TestWebSite.Models
{
    public class Newsletter
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String? Email { get; set; }
    }
}
