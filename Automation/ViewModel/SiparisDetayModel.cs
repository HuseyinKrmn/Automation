using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Automation.ViewModel
{
    public class SiparisDetayModel
    {
        public int SiparisDetayi_Id { get; set; }
        public int Urun_Id { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Miktar { get; set; }
        public decimal Indirim { get; set; }
        public decimal Toplam { get; set; }
    }
}