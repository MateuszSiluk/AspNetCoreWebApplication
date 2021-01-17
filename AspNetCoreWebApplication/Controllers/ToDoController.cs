using AspNetCoreWebApplication.Services;
using AspNetCoreWebApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApplication.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ToDoService _service;

        public ToDoController(ToDoService service)
        {
            _service = service;
        }

        [Route("/ToDo/Category/{category}")]
        public ActionResult Category([FromRoute]string category)
        {
            CategoryViewModel viewModel = new CategoryViewModel();
            viewModel.ListModels = _service.GetItemsForCategory(category);

            return View(viewModel);
        }
    }
}
