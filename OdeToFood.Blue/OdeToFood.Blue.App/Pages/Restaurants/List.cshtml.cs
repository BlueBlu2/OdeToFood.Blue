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
        [TempData]
        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public ListModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }
        public void OnGet()
        {
            Restaurants = _restaurantData.GetRestaurantsByName(SearchTerm); 
        }
    }
}
