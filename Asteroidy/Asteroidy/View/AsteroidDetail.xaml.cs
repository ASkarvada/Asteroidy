using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Asteroidy.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AsteroidDetail : ContentPage
    {
        
        public AsteroidDetail()
        {
            InitializeComponent();

            Name.Text = Velocity_kmh.ToString();
        }

        public AsteroidDetail(Asteroid a)
        {
            InitializeComponent();
           
            //Name.Text = 
        }
    }
}