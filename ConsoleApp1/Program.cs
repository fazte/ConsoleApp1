using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace OpenWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            var ApiKey = "6e580dbe0bd8f39079f9ced680c9f682";
            var City = "Kazan";
            var url = $"https://api.openweathermap.org/data/2.5/weather?appid={ApiKey}&q={City}&units=metric";

            var request = WebRequest.Create(url);

            var response = request.GetResponse();
            var httpStatusCode = (response as HttpWebResponse).StatusCode;

            if (httpStatusCode != HttpStatusCode.OK)
            {
                Console.WriteLine(httpStatusCode);
                return;
            }

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();
                Console.WriteLine(result);
                var weatherForecast = JsonConvert.DeserializeObject<Root>(result);
                Console.WriteLine(weatherForecast.main.temp);
            }

        }
    }
}
