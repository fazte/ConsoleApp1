using System;
using System.IO;
using Telegram.Bot;
using System.Net;
using Newtonsoft.Json;
using MyLib;

namespace TelegramBot
{
    class Tg_bot
    {
        static void Main(string[] args)
        {

            TelegramBotClient bot = new TelegramBotClient("1842570799:AAGbItPxpNvtXZGs0v6CKBzrGTnGc_IvERI");

            bot.OnMessage += (s, arg) =>
            {
                Console.WriteLine($"{arg.Message.Chat.FirstName}: {arg.Message.Text}");
                bot.SendTextMessageAsync(arg.Message.Chat.Id, $"You say: {Bot(arg.Message.Text)}");
            };

            bot.StartReceiving();

            Console.ReadKey();
        }
        static string Bot(string s)
        {
            var ApiKey = "2e0e6d59a50c44301f776b63df46a344";
            var City = "Kazan";
            var url = $"https://apidata.mos.ru/v1/datasets/610/rows?api_key={ApiKey}";

            var request = WebRequest.Create(url);

            var response = request.GetResponse();
            var httpStatusCode = (response as HttpWebResponse).StatusCode;

            if (httpStatusCode != HttpStatusCode.OK)
            {
                Console.WriteLine(httpStatusCode);
                return "error";
            }

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();
                var weatherForecast = JsonConvert.DeserializeObject<Root>(result);
                return $"{weatherForecast}";
            }
           

        }
    }
}
