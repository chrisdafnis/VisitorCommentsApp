using System.ComponentModel.DataAnnotations;

namespace VisitorCommentsApp.Models
{
    public class Visitor
    {
        public int Id { get; set; }
        [Required] 
        public string? Name { get; set; }

        public string? Address { get; set; }
        [Required]
        public string? Email { get; set; }
        [Display(Name = "Phone Number 1")]
        public string? Phone1 { get; set; }
        [Display(Name = "Phone Number 2")]
        public string? Phone2 { get; set; }
        [DataType(DataType.MultilineText)] 
        public string? Comments { get; set; }
        public int? Rating { get; set; }
    }
}
