using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Web.Areas.Controllers
{

    public class HomeController : AdminBaseController
    {
        
        
        public IActionResult Index()
        {
            
                TempData[SuccessMessage] = "خوش آمدید";
                return View();
            
        }
    }


}
