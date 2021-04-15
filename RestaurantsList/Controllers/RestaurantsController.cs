using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantsList.Models;
using RestaurantsList.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsList.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        public RestaurantsController(JsonFileRestaurantsService restaurantsService)
        {
            this.RestaurantsService = restaurantsService;
        }
        public JsonFileRestaurantsService RestaurantsService { get; }
        [HttpGet]
        public IEnumerable<Restaurant> Get() => RestaurantsService.GetRestaurants();
        
    }
}
