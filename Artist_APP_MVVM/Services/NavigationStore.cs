﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artist_APP_MVVM.MVVM.ViewModels;

namespace Artist_APP_MVVM.Services
{
    internal class NavigationStore
    {
        public event Action? CurrentViewModelChanged;

        private ObservableObject? _currentViewModel;
        public ObservableObject CurrentViewModel
        {
            get => _currentViewModel!;
            set
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }
        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
