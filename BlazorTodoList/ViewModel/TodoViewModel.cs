using BlazorTodoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTodoList.ViewModels
{
    public class TodoViewModel
    {
        public List<Todo> TodoList { get; set; }

        public TodoViewModel()
        {
            TodoList = new List<Todo>();
        }

        public void AddTodo(string title, bool status = false)
        {
            TodoList.Add(new Todo { Title = title, IsDone = status });
        }
    }
}
