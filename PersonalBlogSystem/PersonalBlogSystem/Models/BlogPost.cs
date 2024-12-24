using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalBlogSystem.Models
{
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("Title", TypeName ="varchar(255)")]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
    }

}
