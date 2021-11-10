using System.Collections.Generic;

namespace WorkingWithComponents.Services
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
            if (continentId == "c1")
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
            else
            {
                return new List<Country>
                {
                    new Country
                    {
                        Id = "id9",
                        Name = "India"
                    },
                    new Country
                    {
                        Id = "id22",
                        Name = "Thailand"
                    }

                };
            }
        }
    }
}
