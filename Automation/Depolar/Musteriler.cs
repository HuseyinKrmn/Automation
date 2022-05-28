using Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Automation.Depolar
{
    public class Musteriler
    {
        private AutomationDbEntities objAutomationDbEntities;


        public Musteriler()
        {
            objAutomationDbEntities = new AutomationDbEntities();
        }


        public IEnumerable<SelectListItem> GetAllMusteriler()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objAutomationDbEntities.Musterilers
                                  select new SelectListItem()
                                  {
                                      Text = obj.Musteri_Ad,
                                      Value = obj.Musteri_Id.ToString(),
                                      Selected = true
                                  }).ToList();
            return objSelectListItems;


            


        }


    }
}