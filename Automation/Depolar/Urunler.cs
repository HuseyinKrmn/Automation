using Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Automation.Depolar
{
    public class Urunler
    {
        private AutomationDbEntities objAutomationDbEntities;


        public Urunler()
        {
            objAutomationDbEntities = new AutomationDbEntities();
        }


        public IEnumerable<SelectListItem> GetAllUrunler()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objAutomationDbEntities.Urunlers
                                  select new SelectListItem()
                                  {
                                      Text = obj.Urun_Ismi,
                                      Value = obj.Urun_Id.ToString(),
                                      Selected = true
                                  }).ToList();
            return objSelectListItems;
        }

    }
}