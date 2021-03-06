﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using System.Net.Http.Json;
using Asteroidy.Model;

namespace Asteroidy.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AsteroidView : ContentPage
    {
       
      
        public AsteroidView()
        {
            InitializeComponent();
           NasaDataService nasaDataService = new NasaDataService();

            l_asteroids.ItemsSource = nasaDataService.GetAsteroids();

            update.Text = $"Naposledy aktualizováno: {DateTime.Now.ToString()}";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new AsteroidDetail(((sender as Button).BindingContext) as Asteroid));
            // ((sender as Button).BindingContext) ... celý objekt svázaný s Button v XAML
            // protože je typu object, musíme castovat na Asteroid (víme, že to je Asteroid, svázali jsme ho s Button v AsteroidView.xaml
        }
    }
}