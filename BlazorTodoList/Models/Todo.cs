using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTodoList.Models
{
    public class Todo
    {
        public bool Selected { get; set; }

        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
