using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "ProductName cannot be empty")]
        [Column(TypeName = "nvarchar(200)")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Quantity cannot be empty")]
        public int? Quantity { get; set; }

        public string Image { get; set; }

        [Required(ErrorMessage = "Price cannot be empty")]
        public float? Price { get; set; }

        public float SalePrice { get; set; }

        [DisplayName("Category")]
        [Required(ErrorMessage = "Category cannot be empty")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }


        public ICollection<OrdersDetails> OrderDetails;
    }
}
