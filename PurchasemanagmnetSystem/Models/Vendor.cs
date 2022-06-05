using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurchasemanagmnetSystem.Models
{
    public class Vendor
    {
        [Key]
        public int vendor_id { get; set; }

        public string vendor_name { get; set; }

        public string item_status { get; set; }
    }
}
