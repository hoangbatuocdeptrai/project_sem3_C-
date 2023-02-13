using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [DisplayName("ID")]
        public int CustomerID { get; set; }

        [DisplayName("Customer Name")]
        [StringLength(100, ErrorMessage = "Username should not exceed 100 characters")]
        [Required(ErrorMessage = "Customer Name cannot be empty")]
        [Column(TypeName = "nvarchar(100)")]
        public string CustomerName { get; set; }
        
        [Required(ErrorMessage = "Address cannot be empty")]
        [Column(TypeName = "nvarchar(200)")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone cannot be empty")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "User name cannot be empty")]
        [Column(TypeName = "varchar(20)")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password cannot be empty")]
        [Column(TypeName = "varchar(15)")]
        public string Password { get; set; }

        [Required(ErrorMessage = "CardNumber cannot be empty")]
        public int CreditCardNumber { get; set; }
    }
}
