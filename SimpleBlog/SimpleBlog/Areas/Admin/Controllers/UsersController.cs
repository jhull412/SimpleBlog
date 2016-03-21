using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        // http://localhost:55482/admin/users/index
        // http://localhost:55482/admin/users
        public ActionResult Index()
        {
            return Content("USERS!");
        }
    }
}