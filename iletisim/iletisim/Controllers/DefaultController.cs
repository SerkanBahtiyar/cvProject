using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iletisim.Models.Entity;
namespace iletisim.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        iletisimEntities1 sb=new iletisimEntities1();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult ilet()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult ilet(tbliletisim t)
        {
            sb.tbliletisim.Add(t);
            sb.SaveChanges();
            return PartialView();
        }
    }
}