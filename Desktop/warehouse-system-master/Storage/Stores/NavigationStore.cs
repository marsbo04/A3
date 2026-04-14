using Storage.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Stores
{
    public class NavigationStore
    {
        public event Action CurrentViewModelChanged;

        public BaseViewModel _currentViewModel;

        public BaseViewModel CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }
        //
        public void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
