using Newtonsoft.Json;

namespace TelegramBot.Models;

public class GetMeModel
{
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("result")]
        public Result? Result { get; set; }
}

public partial class Result
{
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("is_bot")]
        public bool IsBot { get; set; }

        [JsonProperty("first_name")]
        public string? FirstName { get; set; }

        [JsonProperty("username")]
        public string? Username { get; set; }

        [JsonProperty("can_join_groups")]
        public bool CanJoinGroups { get; set; }

        [JsonProperty("can_read_all_group_messages")]
        public bool CanReadAllGroupMessages { get; set; }

        [JsonProperty("supports_inline_queries")]
        public bool SupportsInlineQueries { get; set; }
}