using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurchasemanagmnetSystem.Models
{
    public class Item
    {
        [Key]
        public int id { get; set; }

        public string item_name { get; set; }



        public string item_status { get; set; }
    }
}
