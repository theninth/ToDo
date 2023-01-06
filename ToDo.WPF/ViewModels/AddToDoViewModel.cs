using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ToDo.WPF.Messages;
using ToDo.WPF.Models;

namespace ToDo.WPF.ViewModels;

public partial class AddToDoViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(AddCommand))]
    private string _toDo = string.Empty;

    private bool IsAddable => _toDo.Trim() != string.Empty;

    [RelayCommand(CanExecute = nameof(IsAddable))]
    public void Add()
    {
        ToDoItem toDoItem = new()
        {
            Summary = _toDo
        };
        WeakReferenceMessenger.Default.Send(new AddedTodoMessage(toDoItem));
        ToDo = string.Empty;
    }
}