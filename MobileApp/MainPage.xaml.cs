﻿using MobileApp.MVVM.ViewModels;

namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext= viewModel;
        }

       
    }
}