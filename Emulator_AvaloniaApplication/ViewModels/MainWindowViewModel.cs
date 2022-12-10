using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emulator_AvaloniaApplication.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string greeting = "Welcome to Avalonia!";

        public void ExitCommand()
        {
            Greeting = "Hi Stu";
            
        }
    }
}
