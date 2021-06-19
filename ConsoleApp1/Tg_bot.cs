using System;
using System.IO;
using Telegram.Bot;

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
                bot.SendTextMessageAsync(arg.Message.Chat.Id, $"You say: {arg.Message.Text}");
            };

            bot.StartReceiving();

            Console.ReadKey();
        }
    }
}
