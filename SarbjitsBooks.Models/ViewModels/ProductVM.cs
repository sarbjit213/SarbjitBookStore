using System.Collections.Generic;
using System.Web.Mvc;

namespace SarbjitsBooks.Models.ViewModels
{
    public class ProductVM
    {
        public Product product { get; set; }
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }


    }
}
