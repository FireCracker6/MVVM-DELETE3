﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPF_APP_CONTACTS_MVVM.MVVM.Models;
using WPF_APP_CONTACTS_MVVM.Services;

namespace WPF_APP_CONTACTS_MVVM.MVVM.ViewModels
{
    public partial class AddContactViewModel : ObservableObject
    {
       // private readonly FileService fileService;
        public ContactModel SelectedItem { get; set; } = null!;
     

        [ObservableProperty]
        private string pageTitle = "Add Artist";

        [ObservableProperty]
        private string artist = string.Empty;
        [ObservableProperty]
        private string associates = string.Empty;
        [ObservableProperty]
        private string recordlabel = string.Empty;
        [ObservableProperty]
        private string artistsongs = string.Empty;



        [RelayCommand]
        private void Add()
        {
           ContactService.AddToList(new ContactModel { ArtistName = Artist, Associates = Associates, RecordLabel = Recordlabel, ArtistSongs = Artistsongs  });
       MessageBox.Show(Artist.ToString() + " added");
            Associates = string.Empty;
            //Associates = string.Empty;
            //Recordlabel = string.Empty;

        }
       

    }
}
