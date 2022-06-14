using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace SanTsgBootcamp.Web.Models
{
    public class searchmodel
    {
        public int id { get; set; }
        public string sehir { get; set; }
       public List<SelectListItem> selectListItems { get; set; }
    }
}
