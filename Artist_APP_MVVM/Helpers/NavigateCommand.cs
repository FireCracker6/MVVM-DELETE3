﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artist_APP_MVVM.MVVM.ViewModels;
using Artist_APP_MVVM.Services;

namespace Artist_APP_MVVM.Helpers
{
    internal class NavigateCommand<T> : BaseCommand where T : ObservableObject
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<T> _createViewModel;

        public NavigateCommand(NavigationStore navigationStore, Func<T> createViewModel)
        {
           _navigationStore = navigationStore;
            _createViewModel = createViewModel;

        }


        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}
