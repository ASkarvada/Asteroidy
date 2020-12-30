using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Asteroidy
{
    

    class AsteroidsListViewModel
    {
        public List<Asteroid> Asteroids { get; set; }
        public string UpdateText { get; set; }

        public AsteroidsListViewModel()
        {
            Asteroids = new List<Asteroid>();
            Asteroids.Add(new Asteroid("QK4 2019", new DateTime(2019, 9, 7, 10, 4, 0), 38.34, 138058.94, 10, 20, 1, 2, 20, 3, 1));
            Asteroids.Add(new Asteroid("QK4 2019", new DateTime(2019, 9, 7, 10, 4, 0), 38.34, 138058.94, 10, 20, 1, 2, 20, 3, 1));
            Asteroids.Add(new Asteroid("QK4 2019", new DateTime(2019, 9, 7, 10, 4, 0), 38.34, 138058.94, 10, 20, 1, 2, 20, 3, 1));
            Asteroids.Add(new Asteroid("QK4 2019", new DateTime(2019, 9, 7, 10, 4, 0), 38.34, 138058.94, 10, 20, 1, 2, 20, 3, 1));
            UpdateTextUpload(new DateTime(1,1,1,1,1,1));
        }

        public void AddAsteroid()
        {
            //Asteroids.Add
        }
        public void UpdateTextUpload(DateTime date)
        {
            if (date == new DateTime(1,1,1,1,1,1))
            {
                UpdateText = "Není dostupné info o aktualizaci";
            }
            else
            {
                UpdateText = $"Naposledy aktualizováno: {date}";
            }
        }
    }
}
