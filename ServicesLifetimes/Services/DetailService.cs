using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesLifetimes.Services
{
    public class Country
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class DetailService
    {
        public List<Country> GetCountries(string continentId)
        {
            return new List<Country>
            {
                new Country
                {
                    Id = "id1",
                    Name = "Belgium"
                },
                new Country
                {
                    Id = "id2",
                    Name = "France"
                }

            };
        }
    }
}
