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

        public AsteroidsListViewModel()
        {
            Asteroids = new List<Asteroid>();
            Asteroids.Add(new Asteroid("QK4 2019", new DateTime(2019, 9, 7, 10, 4, 0), 38.34, 138058.94, 10, 20, 1, 2, 20, 3, 1));
            Asteroids.Add(new Asteroid("QK4 2019", new DateTime(2019, 9, 7, 10, 4, 0), 38.34, 138058.94, 10, 20, 1, 2, 20, 3, 1));
            Asteroids.Add(new Asteroid("QK4 2019", new DateTime(2019, 9, 7, 10, 4, 0), 38.34, 138058.94, 10, 20, 1, 2, 20, 3, 1));
            Asteroids.Add(new Asteroid("QK4 2019", new DateTime(2019, 9, 7, 10, 4, 0), 38.34, 138058.94, 10, 20, 1, 2, 20, 3, 1));
        }

        public void AddAsteroid()
        {
            //Asteroids.Add
        }
    }
}
