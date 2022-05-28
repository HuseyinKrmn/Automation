using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Automation.Depolar;
using Automation.Models;
using Automation.ViewModel;

namespace Automation.Controllers
{
    public class HomeController : Controller
    {
        private AutomationDbEntities objAutomationDbEntities;
        public HomeController()
        {
            objAutomationDbEntities = new AutomationDbEntities();
        }
        // GET: Home
        public ActionResult Index()
        {
            
            Depolar.Musteriler objMusteriler = new Depolar.Musteriler();
            Depolar.Urunler objUrunler = new Depolar.Urunler();
            OdemeTipleri objOdemeTipleri = new OdemeTipleri();
            var objCokluModeller = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                        (objMusteriler.GetAllMusteriler(), objUrunler.GetAllUrunler(), objOdemeTipleri.GetAllOdemeTuru());


            return View(objCokluModeller);
        }

        // sayfa açılınca çalışan metod
        [HttpGet]
        public JsonResult GetUrunBirimFiyat(int UrunId)
        {
            decimal _BirimFiyat = objAutomationDbEntities.Urunlers.Single(model => model.Urun_Id == UrunId).Urun_Fiyat;
            return Json(_BirimFiyat, JsonRequestBehavior.AllowGet);

        }

        // Ekle Butonuna basılnca çalıştıran metod
        [HttpPost]
        public JsonResult Index(SiparisModel objSiparisModel)
        {
            siparislerr objSiparislerr = new siparislerr();
            objSiparislerr.SiparisEkle(objSiparisModel);
            return Json(data:"Ödemeniz başarıyla gerçekleşti.", JsonRequestBehavior.AllowGet);
        }



    }
}