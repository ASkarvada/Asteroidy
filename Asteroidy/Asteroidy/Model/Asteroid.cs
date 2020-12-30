using System;
using System.Collections.Generic;
using System.Text;

namespace Asteroidy
{
    class Asteroid
    {
        public string Name { get; set; }
        public DateTime CloseApproachDate { get; set; }
        public double Velocity_kms { get; set; }
        public double Velocity_kmh { get; set; }
        public double EstimatedDiameter_m_min { get; set; }
        public double EstimatedDiameter_m_max { get; set; }
        public double EstimatedDiameter_km_min { get; set; }
        public double EstimatedDiameter_km_max { get; set; }
        public double MissDistance_km { get; set; }
        public double MissDistance_au { get; set; }
        public double MissDistance_LD { get; set; }
        public string Description { get; set; }

        public Asteroid(string name, DateTime closeApproachDate, double velocity_kms, double velocity_kmh, double estimatedDiameter_m_min, double estimatedDiameter_m_max, double estimatedDiameter_km_min, double estimatedDiameter_km_max, double missDistance_km, double missDistance_au, double missDistance_LD)
        {
            Name = name;
            CloseApproachDate = closeApproachDate;
            Velocity_kms = velocity_kms;
            Velocity_kmh = velocity_kmh;
            EstimatedDiameter_m_min = estimatedDiameter_m_min;
            EstimatedDiameter_m_max = estimatedDiameter_m_max;
            EstimatedDiameter_km_min = estimatedDiameter_km_min;
            EstimatedDiameter_km_max = estimatedDiameter_km_max;
            MissDistance_km = missDistance_km;
            MissDistance_au = missDistance_au;
            MissDistance_LD = missDistance_LD;
            Description = CreateDescription(closeApproachDate, velocity_kms, estimatedDiameter_m_min, estimatedDiameter_m_max);
        }

        private string CreateDescription(DateTime closeApproachDate, double velocity_kms, double estimatedDiameter_m_min, double estimatedDiameter_m_max)
        {
            return $@"Datum přiblížení: {closeApproachDate}
Rychlost: {velocity_kms} km/s
Odhadovaný průměr: {estimatedDiameter_m_min} - {estimatedDiameter_m_max} m";
        }
    }
}
