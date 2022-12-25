using Newtonsoft.Json;
using TelegramBot.Models;

namespace TelegramBot;

public class BotRequest
{
    private readonly string _token;
    
    public BotRequest(string token)
    {
        this._token = token;
    }
    
    private static readonly HttpClient Client = new HttpClient();
    
    public async Task<Result?> GetMe() => Deserialize<GetMeModel>(await Client.GetStringAsync(
        $"https://api.telegram.org/bot{_token}/getMe"))?.Result;
    public async Task<Result[]?> GetUpdates() => Deserialize<GetUpdatesModel>(await Client.GetStringAsync(
        $"https://api.telegram.org/bot{_token}/getUpdates"))?.Result;
    
    public async Task SendMessage(int chatId, string text) => await Client.GetStringAsync(
        $"https://api.telegram.org/bot{_token}/sendMessage?chat_id={chatId}&text={text}");
    
    public async Task SendMessage(int chatId, string text, string parseMode) => await Client.GetStringAsync(
        $"https://api.telegram.org/bot{_token}/sendMessage?chat_id={chatId}&text={text}&parse_mode={parseMode}");
    
    private static T? Deserialize<T>(string response) => JsonConvert.DeserializeObject<T>(response);
}