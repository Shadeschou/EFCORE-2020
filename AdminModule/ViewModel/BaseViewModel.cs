using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using AdminModule.Utility;
using GalaSoft.MvvmLight.Messaging;

namespace AdminModule.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public enum Views
        {
            ManageCustomerView,
            DeleteCustomerPageView,AddCustomerPageView
        }
        

        public ICommand ChangeView => new CustomCommand((object obj) =>
        {
            string input = obj as string;

            Messenger.Default.Send<Views>((Views)Enum.Parse(typeof(Views), input));
        });
    }
}
