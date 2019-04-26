using System.Collections;
using System.Collections.Generic;

namespace WebApiDemo.Models
{
    public class TodoItemRepository : ITodoItem
    {
        public List<TodoItem> _todoItems;
        public TodoItemRepository()
        {
            // _todoItems = new List<TodoItem>()
            // {
            //     new TodoItem(1,"Feed Corgi", true),
            // new TodoItem(2, "Sweep the Floor", false)
            // };
        }
        public List<TodoItem> getAll()
        {
            return _todoItems;
        }
        public TodoItem getOne(int id)
        {
            foreach (TodoItem each in _todoItems)
            {
                if (each.Id == id)
                {
                    return each;
                }
            }
            return null;
        }
    }
}