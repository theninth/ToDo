using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ToDo.WPF.Messages;

public sealed class AddedTodoMessage
{
    public string ToDo { get; set; }

    public AddedTodoMessage(string toDo)
    {
        ToDo = toDo;
    }
}