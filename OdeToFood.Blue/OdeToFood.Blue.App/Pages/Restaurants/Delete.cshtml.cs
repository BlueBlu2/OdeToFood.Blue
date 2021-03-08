using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Blue.Core;
using OdeToFood.Blue.Data;

namespace OdeToFood.Blue.App.Pages.Restaurants
{
    public class DeleteModel : PageModel
    {
        private readonly IRestaurantData _restaurant;
        public Restaurant Restaurant { get; set; }
        public DeleteModel(IRestaurantData restaurant)
        {
            _restaurant = restaurant;
        }
        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = _restaurant.GetById(restaurantId);
            return Restaurant == null ? (ActionResult)RedirectToPage("./NotFound") : Page();
        }
        public IActionResult OnPost(int restaurantId)
        {
            var restaurant = _restaurant.Delete(restaurantId);
            _restaurant.Commit();
            if (restaurant == null) {
                return RedirectToPage("./NotFound");
            }
            TempData["Message"] = $"{restaurant.Name} deleted";
            return RedirectToPage("./List");
        }

    }
}
