using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.Ajax.Utilities;
using MVCproje.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace MVCproje.Controllers
{
    public class StatisticController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        WriterManager wm = new WriterManager(new EfWriterDal());



        public ActionResult Statistic()
        {
            TestViewModel modeladı = new TestViewModel();
            modeladı.TestCategories = cm.GetList();
            modeladı.TestHeadings = hm.GetList();
            modeladı.TestWriter = wm.GetList();
            
                return View(modeladı);
        }



    }
}