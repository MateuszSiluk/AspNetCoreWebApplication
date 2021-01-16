using AspNetCoreWebApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApplication.Services
{
    public class ToDoService
    {
        List<ToDoListModel> toDoLists = new List<ToDoListModel>();

        public List<ToDoListModel> GetItemsForCategory(string category)
        {
            if(category!=null)
            {
                toDoLists.Add(new ToDoListModel { Id = 1, Name = "Homework" });
                toDoLists.Add(new ToDoListModel { Id = 2, Name = "Do dishes" });
                toDoLists.Add(new ToDoListModel { Id = 3, Name = "Visit market" });
                toDoLists.Add(new ToDoListModel { Id = 4, Name = "Go to work" });
            }
            return toDoLists;
        }
    }
}
