using ToDo.WPF.Models;

namespace ToDo.WPF.Messages;

public sealed class AddedTodoMessage
{
    public ToDoItem ToDoItem { get; set; }

    public AddedTodoMessage(ToDoItem toDoItem)
    {
        ToDoItem = toDoItem;
    }
}