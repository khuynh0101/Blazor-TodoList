using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Data
{
    public class ToDoItem
    {
        public string Value { get; set; }
        public bool isEditable { get; set; }
        public bool isCrossedOut { get; set; }
        public ToDoItem(string val)
        {
            Value = val;
            isEditable = false;
            isCrossedOut = false;
        }
    }
}
