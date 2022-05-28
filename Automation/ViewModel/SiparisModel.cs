using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Automation.ViewModel
{
    public class SiparisModel
    {
        public int SiparisId { get; set; }
        public int OdemeTuru_Id { get; set; }
        public int Musteri_Id { get; set; }
        public string SiparisNo { get; set; }
        public DateTime SiparisGun { get; set; }
        public decimal SonToplam { get; set; }

        public IEnumerable<SiparisDetayModel> SiparisDetayModelListesi { get; set; }
    }
}