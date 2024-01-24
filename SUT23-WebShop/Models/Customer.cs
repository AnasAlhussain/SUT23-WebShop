using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_WebShop.Models
{
    internal class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

        //Navigation prop Customer kan ha 0 eller flera Orders
        //(One to Many)
        public ICollection<Order> Orders { get; set; }

    }
}
