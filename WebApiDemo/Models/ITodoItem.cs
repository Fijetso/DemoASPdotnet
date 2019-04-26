using System.Collections;
using System.Collections.Generic;
namespace WebApiDemo.Models
{
    public interface ITodoItem
    {
        TodoItem getOne(int id);
        List<TodoItem> getAll();
    }
}