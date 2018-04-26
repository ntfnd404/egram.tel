using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class GetChatAdministrators : Method<Users>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "getChatAdministrators";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

    }

}
