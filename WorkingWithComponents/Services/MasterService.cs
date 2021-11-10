using System.Collections.Generic;

namespace WorkingWithComponents.Services
{
    public class Continent
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class MasterService
    {
        public List<Continent> GetContinents()
        {
            return new List<Continent>
            {
                new Continent
                {
                    Id = "c1",
                    Name = "Europe"
                },
                new Continent
                {
                    Id = "c2",
                    Name = "Asia"
                },
            };
        }
    }
}
