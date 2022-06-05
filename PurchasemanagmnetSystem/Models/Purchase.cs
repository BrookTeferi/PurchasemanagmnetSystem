using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurchasemanagmnetSystem.Models
{
    public class Purchase
    {
        [Key]
        public int product_id { get; set; }
        public string purchase_item { get; set; }
        public int product_qty { get; set; }
        public double product_price { get; set; }
        public DateTime pur_date { get; set; }

        public string vendor { get; set; }
     
    }
}
