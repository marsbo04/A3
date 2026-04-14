using System;
using System.Collections.Generic;
using System.Text;
using Storage.Service;
using Storage.Stores; 
using Storage.Commands; 
namespace Storage.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public readonly NavigationStore _navigationStore;
        public BaseViewModel CurrentViewModel => _navigationStore.CurrentViewModel;

        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        public void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }


    }
}
