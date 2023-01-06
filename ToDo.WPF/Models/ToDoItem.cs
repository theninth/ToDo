using CommunityToolkit.Mvvm.ComponentModel;

namespace ToDo.WPF.Models;

public partial class ToDoItem : ObservableObject
{
    [ObservableProperty]
    private bool _isDone;

    [ObservableProperty]
    private string _summary = string.Empty;
}