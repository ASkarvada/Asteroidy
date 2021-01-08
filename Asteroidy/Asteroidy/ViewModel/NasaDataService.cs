using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using Asteroidy.Model;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace Asteroidy
{
    

    class NasaDataService
    {
     
        public string UpdateText { get; set; }
        private HttpClient client = new HttpClient();
        

        const string API_URL = "https://api.nasa.gov/neo/rest/v1/neo/browse?api_key=kTlB1068LXF3IZeIHqWRPhMeFSNgvZVKyPOCRoRd";

      
        public async Task<NasaResponse> SnatchData()
        {
            return await client.GetFromJsonAsync<NasaResponse>(API_URL).ConfigureAwait(false);
        }

        public List<Asteroid> GetAsteroids()
        {
            try
            {
                List<Asteroid> asteroids =  MapNasaResponseToAsteroids(SnatchData().Result);

                //localStorage.lastChange = new DateTime(); 

                return asteroids;
            }
            catch
            {
                
                throw new Exception("Not implemented!");
            }

        }

        
        private List<Asteroid> MapNasaResponseToAsteroids(NasaResponse nasaResponse)
        {
            List<Asteroid> asteroids = new List<Asteroid>();
            foreach(NearEarthObject nearEarthObject in nasaResponse.near_earth_objects) //každej jeden asteroid
            {
                List<CloseApproachData> l_close_approach_data = nearEarthObject.close_approach_data; //přílety
                CloseApproachData closeApproachData = FindNearestApproach(l_close_approach_data);
                asteroids.Add(new Asteroid(nearEarthObject.name, closeApproachData.close_approach_date_full, closeApproachData.relative_velocity.kilometers_per_second, closeApproachData.relative_velocity.kilometers_per_hour, nearEarthObject.estimated_diameter.meters.estimated_diameter_min, nearEarthObject.estimated_diameter.meters.estimated_diameter_max, nearEarthObject.estimated_diameter.kilometers.estimated_diameter_min, nearEarthObject.estimated_diameter.kilometers.estimated_diameter_max, closeApproachData.miss_distance.kilometers, closeApproachData.miss_distance.astronomical, closeApproachData.miss_distance.lunar));
            }
            return asteroids;
        }

        private CloseApproachData FindNearestApproach(List<CloseApproachData> l_close_approach_data)
        {
            int today = DateTime.Now.Year;
            List<int> listOfYears = new List<int>();
            foreach (CloseApproachData item in l_close_approach_data)
            {
                listOfYears.Add(Convert.ToInt32(item.close_approach_date.Remove(4)));
            }
            int closest = listOfYears.OrderBy(item => Math.Abs(today - item)).First();
            foreach (CloseApproachData item in l_close_approach_data)
            {
                if (closest == Convert.ToInt32(item.close_approach_date.Remove(4))) return item;
            }
            return l_close_approach_data[0]; //nemělo by se stát
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
