using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ToDo.WPF.Messages;

namespace ToDo.WPF.ViewModels;

public partial class ToDoListViewModel : ObservableObject
{
    public ObservableCollection<string> Items { get; set; } = new();

    public ToDoListViewModel()
    {
        WeakReferenceMessenger.Default.Register<AddedTodoMessage>(this, (r, m) =>
        {
            Items.Add(m.ToDo);
        });
    }

    [RelayCommand]
    public void Delete(string toDo)
    {
        Items.Remove(toDo);
    }
}