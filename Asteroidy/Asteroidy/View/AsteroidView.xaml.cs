﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Asteroidy.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AsteroidView : ContentPage
    {
        AsteroidsListViewModel vm;
        public AsteroidView()
        {
            InitializeComponent();
            vm = new AsteroidsListViewModel();
            l_asteroids.ItemsSource = vm.Asteroids;
            update.Text = vm.UpdateText;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new AsteroidDetail(label));
        }
    }
}