using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iletisim.Models.Entity;
namespace iletisim.Controllers
{
    public class mesajlarController : Controller
    {
        // GET: mesajlar
        iletisimEntities1 sb=new iletisimEntities1();
        public ActionResult Index(string p)
        {
            var degerler = from x in sb.tbliletisim select x;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(y => y.adSoyad.Contains(p));

            }
            return View(degerler.ToList());
        }
     
    }
}