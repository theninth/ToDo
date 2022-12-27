using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using ToDo.WPF.ViewModels;

namespace ToDo.WPF;

public partial class MainWindow : Window
{
    public MainWindow(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        var toDoListViewModel = serviceProvider.GetService<ToDoListViewModel>();
        var addTodoViewModel = serviceProvider.GetService<AddToDoViewModel>();
        ToDoList.DataContext = toDoListViewModel;
        AddToDo.DataContext = addTodoViewModel;
    }
}