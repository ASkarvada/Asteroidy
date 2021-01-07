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
        AsteroidsListViewModel vm;
        public AsteroidDetail()
        {
            InitializeComponent();
            vm = new AsteroidsListViewModel();
            //Name.Text = 
        }

        public AsteroidDetail(Asteroid a)
        {
            InitializeComponent();
            vm = new AsteroidsListViewModel();
            //Name.Text = 
        }
    }
}