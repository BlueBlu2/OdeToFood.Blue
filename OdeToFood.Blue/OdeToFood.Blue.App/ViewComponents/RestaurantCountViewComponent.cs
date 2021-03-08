using Microsoft.AspNetCore.Mvc;
using OdeToFood.Blue.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Blue.App.ViewComponents
{
    public class RestaurantCountViewComponent : ViewComponent
    {
        private readonly IRestaurantData _restaurant;

        public RestaurantCountViewComponent(IRestaurantData restaurant)
        {
            _restaurant = restaurant;
        }

        public IViewComponentResult Invoke()
        {
            var count = _restaurant.GetCountOfRestaurants();
            return View(count);
        }
    }
}
