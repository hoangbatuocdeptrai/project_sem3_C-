using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Models
{
    public class OrdersDetails
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Order Id cannot be empty")]
        public int OrderId { get; set; }
        [Required(ErrorMessage = "ProductId cannot be empty")]
        public int ProductId { get; set; }
        
        public int CreditCardNumber { get; set; }
        public int Quantity { get; set; }

        public double Price { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd / MM / yyyy}")]
        [DefaultValue("getdate()")]
        public DateTime Createdate { get; set; }

        public bool Status { get; set; }

        public Orders Orders { get; set; }
        public Product Product { get; set; }
    }
}
