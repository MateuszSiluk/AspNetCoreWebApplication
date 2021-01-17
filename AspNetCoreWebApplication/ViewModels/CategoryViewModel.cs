using AspNetCoreWebApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApplication.ViewModels
{
    public class CategoryViewModel
    {
        public IEnumerable<ToDoListModel> ListModels{ get; set; }
        public string CurrentCategory { get; set; }


    }
}
