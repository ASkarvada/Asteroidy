using System;
using System.Collections.Generic;
using System.Text;

namespace Asteroidy
{

    public class Asteroid
    {
        public string Name { get; set; }
        public string CloseApproachDate { get; set; }
        public string Velocity_kms { get; set; }
        public string Velocity_kmh { get; set; }
        public string EstimatedDiameter_m { get; set; }
        public string EstimatedDiameter_km { get; set; }
        public string MissDistance_km { get; set; }
        public string MissDistance_au { get; set; }
        public string MissDistance_LD { get; set; }
        public string Description { get; set; }

        public Asteroid(string name, string closeApproachDate, string velocity_kms, string velocity_kmh, double estimatedDiameter_m_min, double estimatedDiameter_m_max, double estimatedDiameter_km_min, double estimatedDiameter_km_max, string missDistance_km, string missDistance_au, string missDistance_LD)
        {
            Name = name;
            CloseApproachDate = closeApproachDate;
            Velocity_kms = Around(velocity_kms, 4) + " km/s";
            Velocity_kmh = Around(velocity_kmh, 8) + " km/h";
            EstimatedDiameter_m = Around(estimatedDiameter_m_min.ToString(), 8) + " - " + Around(estimatedDiameter_m_max.ToString(), 8) + " m";
            EstimatedDiameter_km = Around(estimatedDiameter_km_min.ToString(), 5) + " - " + Around(estimatedDiameter_km_max.ToString(), 5) + " km";
            MissDistance_km = Around(missDistance_km, 11) + " km";
            MissDistance_au = Around(missDistance_au, 4) + " au";
            MissDistance_LD = Around(missDistance_LD, 5) + " LD";
            Description = CreateDescription(closeApproachDate, Velocity_kms, EstimatedDiameter_m);
        }

        private string CreateDescription(string closeApproachDate, string velocity_kms, string estimatedDiameter_m)
        {
            return $@"Datum přiblížení: {closeApproachDate}
Rychlost: {velocity_kms}
Odhadovaný průměr: {estimatedDiameter_m}";
        }

        private string Around(string s, int i)
        {
            return s.Remove(i);
        }

       /* private string CreateDate(string s)
        {
            
        }*/

       

    }
}
