using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Automation.Models;

namespace Automation.Depolar
{
    public class OdemeTipleri
    {

        private AutomationDbEntities objAutomationDbEntities;


        public OdemeTipleri()
        {
            objAutomationDbEntities = new AutomationDbEntities();
        }


        public IEnumerable<SelectListItem> GetAllOdemeTuru()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objAutomationDbEntities.OdemeTurus
                                  select new SelectListItem()
                                  {
                                      Text = obj.OdemeTuru_Ismi,
                                      Value = obj.OdemeTuru_Id.ToString(),
                                      Selected = true
                                  }).ToList();
            return objSelectListItems;
        }



    }
}