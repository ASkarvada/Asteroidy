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

            
        }

        public AsteroidDetail(Asteroid a)
        {
            InitializeComponent();

            Name.Text = a.Name;
            CloseApproachDate.Text = a.CloseApproachDate;
            Velocity_kms.Text = a.Velocity_kms;
            Velocity_kmh.Text = a.Velocity_kmh;
            EstimatedDiameter_m.Text = a.EstimatedDiameter_m;
            EstimatedDiameter_km.Text = a.EstimatedDiameter_km;
            MissDistance_km.Text = a.MissDistance_km;
            MissDistance_au.Text = a.MissDistance_au;
            MissDistance_LD.Text = a.MissDistance_LD;
        }
    }
}