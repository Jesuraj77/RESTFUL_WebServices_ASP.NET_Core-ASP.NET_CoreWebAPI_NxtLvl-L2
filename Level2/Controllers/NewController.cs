using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Level2.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            //Use Event Log and Trace Source to log data.

           // 2.Use third party library as NLog to Log Data.

            //3.On an Error send a proper response from the api’s built in the previous steps. (eg: BadRequest

            return View();
        }
    }
}