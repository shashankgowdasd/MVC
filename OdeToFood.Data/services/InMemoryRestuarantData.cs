using OdeToFood.Data.model;
using System;
using System.Collections.Generic;

namespace OdeToFood.Data.services
{
    public class InMemoryRestuarantData : IRestuarantData
    {
        List<Restuarant> restuarants;

        public InMemoryRestuarantData(List<Restuarant> restuarants)
        {
            restuarants = new List<Restuarant>();
            {

                new Restuarant { Id = 1, Name = "manoj", cuisine = CuisineType.French };
                new Restuarant { Id = 2, Name = "sujith", cuisine = CuisineType.Italian };
                new Restuarant { Id = 3, Name = "shashank", cuisine = CuisineType.Indian };
            }
        }

        IEnumerable<Restuarant> IRestuarantData.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
