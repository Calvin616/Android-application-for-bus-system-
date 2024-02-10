using System;
using System.Collections.Generic;
using System.ComponentModel;
using TrackerX.Models;
using TrackerX.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrackerX.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}