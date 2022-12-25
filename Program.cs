using TelegramBot;
using TelegramBot.Models;

DotNetEnv.Env.Load();

var token = DotNetEnv.Env.GetString("BOT_TOKEN");
var bot = new BotRequest(token);

var a = bot.GetMe();
var b = bot.GetUpdates();

await bot.SendMessage(330836935, "<b>Hey yey</b>");
await bot.SendMessage(330836935, "<b>Hey yey</b>", ParseMode.Html);

Console.WriteLine(a.Result?.Id);
Console.WriteLine(b.Result?[0].Message?.Text);