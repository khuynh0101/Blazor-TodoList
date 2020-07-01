using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Data
{
    public class TodoList : IEnumerable<ToDoItem>
    {
        private List<ToDoItem> todos = new List<ToDoItem>();

        public int Count() {
            return todos.Count();
        }
        public void AddItem(string value)
        {
            todos.Add(new ToDoItem(value));

        }

        public void UpdateItem(int index, string value)
        {
            todos[index].Value = value;
        }

        public void RemoveItem(int index)
        {
            todos.RemoveAt(index);
        }

        public IEnumerator<ToDoItem> GetEnumerator()
        {
            for (int index = 0; index < todos.Count(); index++)
            {
                yield return todos[index];
            }
        }

        public ToDoItem this[int i]
        {
            get { return todos[i]; }
            set { todos[i] = value; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
