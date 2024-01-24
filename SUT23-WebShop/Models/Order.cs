using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_WebShop.Models
{
    internal class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime OrderPlaced { get; set; }
        public DateTime OrderFullFilled { get; set; }

        //EF Ska genrera en FK i backgrunden
        //om vi skriva inte public int CustimerID { get; set; }
        public int CustomerID { get; set; }
        public Customer Cusotmer { get; set; }

        public ICollection<ProductOrder> ProductOrders { get; set; }



    }
}
