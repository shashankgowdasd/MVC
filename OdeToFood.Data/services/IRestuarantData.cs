using OdeToFood.Data.model;
using System.Collections.Generic;

namespace OdeToFood.Data.services
{
    public interface IRestuarantData 
    {
        IEnumerable<Restuarant> GetAll();


    }
}
