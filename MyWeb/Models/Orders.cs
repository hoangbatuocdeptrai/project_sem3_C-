using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }

        public int CustomerId { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd / MM / yyyy}")]
        [DefaultValue("getdate()")]
        public DateTime OrdersDate { get; set; }

        [Required(ErrorMessage = "Please enter Address")]
        public string Address { get; set; }

        public float TotalPrice { get; set; }

        public byte Status { get; set; }

        public Customer Customer { get; set; }

        public ICollection<OrdersDetails> OrderDetails;

    }
}
