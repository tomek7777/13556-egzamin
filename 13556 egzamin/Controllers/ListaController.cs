using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13556_egzamin.Controllers
{
    public class ListaController : Controller
    {

        public IActionResult Index()
        {

            return View();
        }
    }
}
