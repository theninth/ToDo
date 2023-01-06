using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ToDo.WPF.Messages;
using ToDo.WPF.Models;

namespace ToDo.WPF.ViewModels;

public partial class ToDoListViewModel : ObservableObject
{
    public ObservableCollection<ToDoItem> Items { get; set; } = new();

    public ToDoListViewModel()
    {
        WeakReferenceMessenger.Default.Register<AddedTodoMessage>(this, (r, m) =>
        {
            Items.Add(m.ToDoItem);
        });
    }

    [RelayCommand]
    public void Delete(ToDoItem toDo)
    {
        Items.Remove(toDo);
    }
}