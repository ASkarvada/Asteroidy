using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using Asteroidy.Model;

namespace Asteroidy
{
    

    class NasaDataService
    {
     
        public string UpdateText { get; set; }
        private HttpClient client = new HttpClient();
        List<NearEarthObject> response;

        const string API_URL = "https://api.nasa.gov/neo/rest/v1/neo/browse?api_key=kTlB1068LXF3IZeIHqWRPhMeFSNgvZVKyPOCRoRd";

      

        public List<Asteroid> GetAsteroids()
        {
            try
            {   
                List<Asteroid> asteroids =  MapNasaResponseToAsteroids(client.GetFromJsonAsync<NasaResponse>(API_URL).Result);
                
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

            foreach(NearEarthObject nearEarthObject in nasaResponse.near_earth_objects)
            {
                CloseApproachData closeApproachData = nearEarthObject.close_approach_data[nearEarthObject.close_approach_data.Count - 1];

                asteroids.Add(new Asteroid(nearEarthObject.name, , 38.34, 138058.94, 10, 20, 1, 2, 20, 3, 1));
            }
            return asteroids;
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
