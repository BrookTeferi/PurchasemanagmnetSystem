using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurchasemanagmnetSystem.Models
{
    public class Employee : EmployeeBase
    {
        [Key]
        public override int emp_id { get; set; }
        public override string emp_name { get; set; }

    }
}
