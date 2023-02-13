using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DisplayName("ID")]
        public int CategoryId { get; set; }
        [DisplayName("Category Name")]
        [StringLength(100)]
        [Required(ErrorMessage = "Category name cannot be empty")]
        [Column(TypeName = "nvarchar(100)")]
        public string CategoryName { get; set; }
        //khai bao thuoc tính navigation tới thực thể Product
        public ICollection<Product> products { get; set; }
    }

}
