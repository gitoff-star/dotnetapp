using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime CreateDateTime { get; set; } = DateTime.Now;

        [Required]
        public int DisplayOrder { get; set; }



    }
}
