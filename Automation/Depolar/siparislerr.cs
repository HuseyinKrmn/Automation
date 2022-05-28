using Automation.Models;
using Automation.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Automation.Depolar
{
    public class siparislerr
    {
        private AutomationDbEntities objAutomationDbEntities;


        public siparislerr()
        {
            objAutomationDbEntities = new AutomationDbEntities();
        }

        public bool SiparisEkle(SiparisModel objSiparisModel)
        {


            Siparisler objsiparis = new Siparisler();
            objsiparis.Musteri_Id = objSiparisModel.Musteri_Id;
            objsiparis.SonToplam = objSiparisModel.SonToplam;
            objsiparis.SiparisGun = DateTime.Now;
            objsiparis.SiparisNo=string.Format("{0:ddmmmyyyyhhmmss}", DateTime.Now);
            objsiparis.OdemeTuru_Id = objSiparisModel.OdemeTuru_Id;
            objAutomationDbEntities.Siparislers.Add(objsiparis);
            objAutomationDbEntities.SaveChanges();


            int siparisId = objsiparis.SiparisId;
            foreach (var item in objSiparisModel.SiparisDetayModelListesi)
            {
                SiparisDetay objSiparisDetay = new SiparisDetay();
                objSiparisDetay.SiparisId = siparisId;
                objSiparisDetay.Indirim = item.Indirim;
                objSiparisDetay.Urun_Id = item.Urun_Id;
                objSiparisDetay.Toplam = item.Toplam;
                objSiparisDetay.BirimFiyat = item.BirimFiyat;
                objSiparisDetay.Miktar = item.Miktar;
                objAutomationDbEntities.SiparisDetays.Add(objSiparisDetay);
                objAutomationDbEntities.SaveChanges();


                Islemler objIslemler = new Islemler();
                objIslemler.Urun_Id = item.Urun_Id;
                objIslemler.Miktar = (-1)*item.Miktar;
                objIslemler.IslemTarihi = DateTime.Now;
                objIslemler.tip_Id = 2;
                objAutomationDbEntities.Islemlers.Add(objIslemler);
                objAutomationDbEntities.SaveChanges();


            }


            return true;
        }



    }
}