using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ToDo.WPF.Messages;

namespace ToDo.WPF.ViewModels;

public partial class AddToDoViewModel : ObservableObject
{
    [ObservableProperty]
    private string _toDo = String.Empty;



    public AddToDoViewModel()
    {
        
    }

    [RelayCommand]
    public void Add()
    {
        WeakReferenceMessenger.Default.Send(new AddedTodoMessage(ToDo));
    }
}