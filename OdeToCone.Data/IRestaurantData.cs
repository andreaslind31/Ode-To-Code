using OdeToCode.Core;
using System.Collections.Generic;
using System.Linq;

namespace OdeToCone.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {

            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1, Name ="Lilla Napoli", Location="Falkenberg", Cuisine=CuisineType.Italian},
                new Restaurant{Id = 2, Name ="Pinocio", Location="Varberg", Cuisine=CuisineType.Italian},
                new Restaurant{Id = 3, Name ="Campino", Location="Halmstad", Cuisine=CuisineType.Italian},
                new Restaurant{Id = 4, Name ="Stantons", Location="Varberg", Cuisine=CuisineType.Italian},
                new Restaurant{Id = 5, Name ="Gästis", Location="Varberg", Cuisine=CuisineType.Swedish},
                new Restaurant{Id = 6, Name ="Bastard Burgers", Location="Luleå", Cuisine=CuisineType.American},
                new Restaurant{Id = 7, Name ="Flippin Burgers", Location="Stockholm", Cuisine=CuisineType.American},
                new Restaurant{Id = 8, Name ="Stadt", Location="Varberg", Cuisine=CuisineType.Swedish},
                new Restaurant{Id = 9, Name ="Zup Burger", Location="Varberg", Cuisine=CuisineType.American},
                new Restaurant{Id = 10, Name ="Prästgatan", Location="Varberg", Cuisine=CuisineType.Swedish}
            };
        }
        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Location
                   select r;
        }
    }
}
