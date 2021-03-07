using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Blue.Core;
using OdeToFood.Blue.Data;
using System.Collections.Generic;

namespace OdeToFood.Blue.App.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IRestaurantData _restaurantData;
        private readonly IConfiguration _config;

        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            _config = config;
            _restaurantData = restaurantData;
        }
        public void OnGet()
        {
            Message = _config["Message"];
            Restaurants = _restaurantData.GetRestaurantsByName(SearchTerm); 
        }
    }
}
