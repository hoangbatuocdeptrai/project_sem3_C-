using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Models
{
    [Table("Blog")]
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Category name cannot be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Image cannot be empty")]
        public string  Image { get; set; }
        [Column(TypeName = "ntext")]
        public string Text { get; set; }


    }
}
