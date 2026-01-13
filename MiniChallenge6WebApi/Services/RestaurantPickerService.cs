using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallenge6WebApi.Services
{
    public class RestaurantPickerService
    {
        public string[] burgerArray = { "McDonald", "InNOut", "Burger King", "Chick fil-A", "Raising Canes", "Wendy's", "Jack in the Box", "Arby's", "Five Guys", "WhataBurger" };
        public string[] miscArray = { "Denny's", "IHop", "AppleBees", "Subway", "Chipotle", "Taco Bell", "El Frutal", "Olive Garden", "Nena's Mexican Cuisine", "Cheese Cake Factory" };
        public string[] pizzaArray = { "Eddies Pizza", "Mountain Mikes", "Dominos", "Little Caesar", "Sam's Pizza", "Five Guys", "Papa Johns", "Pizza Hut", "MOD pizza", "Costco's pizza" };

        public string GetRestaurant(string category)
        {
            int randomNum = Random.Shared.Next(0,10);
            switch (category.ToLower().Trim())
            {
                case "burger":
                return $"You should get at {burgerArray[randomNum]}!";

                case "pizza":
                return $"You should eat at {pizzaArray[randomNum]}!";

                case "misc":
                return $"You should eat at {miscArray[randomNum]}!";

                default:
                return "Invalid Category! Please enter Pizza, Burger or Misc!";
            }
        }
    }
}