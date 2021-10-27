using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MyRefitAPISpecification;
using Refit;
namespace APIClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.ReadKey();
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:24929");
            httpClient.DefaultRequestHeaders.Add("Authorization","Bearer yxJHKJHKJHKJHKJHKJHKJ");
            var client = RestService.For<IMyFirstAPI>(httpClient);
            try
            {
                var o = await client.DoSometing(new MyDto1());
                Console.WriteLine(o.Field1);
                Console.WriteLine(o.Field2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            







        }

        private static async Task Opzij()
        {
            try
            {
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync("http://localhost:24929/WeatherForecast");

                //httpClient.GetFromJsonAsync()
                response.EnsureSuccessStatusCode();

                var data = await response.Content.ReadAsStringAsync();
                Console.WriteLine(data);
                var o = JsonConvert.DeserializeObject<List<WeatherForecast>>(data);
                foreach (var el in o)
                {
                    Console.WriteLine(el.Summary);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
