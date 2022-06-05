using Microsoft.AspNetCore.Mvc;
using PurchasemanagmnetSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurchasemanagmnetSystem.Controllers
{
    public class ItemController : Controller
    {
        private readonly ConnectionStringClass connectionStringClass;

        public ItemController(ConnectionStringClass cs)
        {
            this.connectionStringClass = cs;
        }


        public IActionResult Display()
        {
            IList<Item> list = connectionStringClass.items.OrderByDescending(x => x.id).ToList();
            return View(list);
        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
