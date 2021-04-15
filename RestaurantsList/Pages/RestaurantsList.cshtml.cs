using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RestaurantsList.Models;
using RestaurantsList.Services;

namespace RestaurantsList.Pages
{
    public class RestaurantsListModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private JsonFileRestaurantsService restaurantsService;
        public IEnumerable<Restaurant> restaurants { get; private set; }
        public RestaurantsListModel(
            ILogger<PrivacyModel> logger, 
            JsonFileRestaurantsService RestaurantsService)
        {
            _logger = logger;
            restaurantsService = RestaurantsService;
        }

        public void OnGet()
        {
            restaurants = restaurantsService.GetRestaurants();
        }
    }
}
