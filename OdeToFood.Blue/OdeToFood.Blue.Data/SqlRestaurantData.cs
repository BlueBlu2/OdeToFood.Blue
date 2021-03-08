using Microsoft.EntityFrameworkCore;
using OdeToFood.Blue.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Blue.Data
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext _db;

        public SqlRestaurantData(OdeToFoodDbContext db)
        {
            _db = db;
        }
        public Restaurant Add(Restaurant newRestaurant)
        {
            _db.Add(newRestaurant);
            return newRestaurant;
        }

        public int Commit()
        {
            return _db.SaveChanges();
        }

        public Restaurant Delete(int Id)
        {
            var restaurant = _db.Restaurants.FirstOrDefault(r => r.Id == Id);
            if(restaurant != null)
            {
                _db.Restaurants.Remove(restaurant);
            }
            return restaurant;
        }

        public Restaurant GetById(int Id)
        {
            return _db.Restaurants.Find(Id);
        }

        public int GetCountOfRestaurants()
        {
            return _db.Restaurants.Count();
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return _db.Restaurants.Where(q => q.Name.StartsWith(name) || string.IsNullOrEmpty(name)).OrderBy(r => r.Name).ToList();
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var entity = _db.Restaurants.Attach(updatedRestaurant);
            entity.State = EntityState.Modified;
            return updatedRestaurant;
        }
    }
}
