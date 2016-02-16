using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReactDemo.Controllers
{
    public class CommentBoxController : Controller
    {
        // GET: CommentBox
        public ActionResult Index()
        {
            return View();
        }
    }
}