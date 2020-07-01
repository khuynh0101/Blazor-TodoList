using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Data;

namespace TodoList.State
{
    public class TodoListState : IEnumerable<ToDoItem>
    {
        private List<ToDoItem> todos = new List<ToDoItem>();
        public event EventHandler StateChanged;

        public int Count() {
            return todos.Count();
        }
        public void AddItem(string value)
        {
            todos.Add(new ToDoItem(value));
            StateHasChanged();

        }

        public void UpdateItem(int index, string value)
        {
            todos[index].Value = value;
            StateHasChanged();
        }

        public void RemoveItem(int index)
        {
            todos.RemoveAt(index);
            StateHasChanged();
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

        private void StateHasChanged()
        {
            // This will update any subscribers
            // that the counter state has changed
            // so they can update themselves
            // and show the current counter value
            StateChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
