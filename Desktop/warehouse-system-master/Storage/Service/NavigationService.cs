using Storage.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using Storage.Stores; 

namespace Storage.Service
{
    public class NavigationService
    {
        private readonly NavigationStore navigationStore;
        private readonly Func<BaseViewModel> viewModelFactory;

        public NavigationService(NavigationStore navigationStore, Func<BaseViewModel> viewModelFactory)
        {
            this.navigationStore = navigationStore;
            this.viewModelFactory = viewModelFactory;
        }

        public void Navigate()
        {
            navigationStore.CurrentViewModel = viewModelFactory();
        }
    }
}
