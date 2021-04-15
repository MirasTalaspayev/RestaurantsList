using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using RestaurantsList.Models;


namespace RestaurantsList.Services
{
    public class JsonFileRestaurantsService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }
        public JsonFileRestaurantsService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;   
        }
        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "Restaurants.json"); }
        }
        public IEnumerable<Restaurant> GetRestaurants()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Restaurant[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions 
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}
