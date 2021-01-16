using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreWebApplication.Model;
using AspNetCoreWebApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreWebApplication.Pages
{
    public class CategoryModel : PageModel
    {
        private readonly ToDoService _service;

        public CategoryModel(ToDoService service)
        {
            _service = service;
        }
        public ActionResult OnGet(string category)
        {
            category = "todolist";
            Items = _service.GetItemsForCategory(category);
            return Page();
        }

        public List<ToDoListModel> Items { get; set; }
    }
}
