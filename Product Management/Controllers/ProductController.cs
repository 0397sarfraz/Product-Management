using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Management.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductDetails()
        {
            return View();
        }
    }
}
