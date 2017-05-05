using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string weatherMapResponse;
            using (StreamReader reader = new StreamReader("Weather.json"))
            {
                weatherMapResponse = reader.ReadToEnd();
            }

            //Console.WriteLine(weatherMapResponse);

            //JObject weatherMapJObject = JObject.Parse(weatherMapResponse);

            //foreach (var child in weatherMapJObject.Children())
            //{
            //    Console.WriteLine(child.Values().ToString());
            //}

            WeatherMap map = JsonConvert.DeserializeObject<WeatherMap>(weatherMapResponse);

            foreach (var weather in map.List)
            {
                Console.WriteLine(weather.Pressure);
            }
        }
    }
}
