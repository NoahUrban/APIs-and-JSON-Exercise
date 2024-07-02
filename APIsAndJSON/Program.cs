using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var client = new HttpClient();
            //var quote = new QuoteGenerator(client);

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("------------------------");
            //    Console.WriteLine($"Kanye: {quote.Kanye()}");

            //    Console.WriteLine($"Ron Swanson: {quote.Ron()}");
            //}

            //Weather API
            var client = new HttpClient();

            var key = "091bb125d9ea839a5525b32249c56ade";
            var city = "Spring Hill";

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}&units=imperial";
            var response = client.GetStringAsync(weatherURL).Result;

            JObject formatResponse = JObject.Parse(response);

            var temp = formatResponse["main"]["temp"];
            Console.WriteLine($"{city}\n" +
                $"Temp: {temp} degrees Fahrenheit");
        }
    }
}
