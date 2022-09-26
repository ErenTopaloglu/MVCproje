using EntityLayer.Concrete;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCproje.ViewModels
{
    public class TestViewModel
    {
        public List<Category> TestCategories = new List<Category>();
        public List<Heading> TestHeadings = new List<Heading>();
        public List<Writer> TestWriter = new List<Writer>();
        public string MostRepeatedCategoryName;
    }
}