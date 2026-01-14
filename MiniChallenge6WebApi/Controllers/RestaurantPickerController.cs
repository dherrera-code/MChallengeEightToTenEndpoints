using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniChallenge6WebApi.Services;

namespace MiniChallenge6WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerService _restaurantPicker;
        public RestaurantPickerController(RestaurantPickerService restaurantPicker)
        {
            _restaurantPicker = restaurantPicker;
        }
        [HttpPost("BurgerPizzaOrMisc/{category}")]
        public string RestaurantPicker(string category)
        {
            return _restaurantPicker.GetRestaurant(category);
        }
    }
}