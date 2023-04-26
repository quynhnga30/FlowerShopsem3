using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ictshop.Areas.Admin.Controllers
{
    public class CommonController : Controller
    {
        // GET: Admin/common
        public ActionResult Index()
        {
            return View("./Areas/Admin/common/404.cshtml");
        }
    }
}