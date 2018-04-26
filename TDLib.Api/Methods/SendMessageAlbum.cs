using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class SendMessageAlbum : Method<Messages>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "sendMessageAlbum";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("reply_to_message_id")]
        public long ReplyToMessageId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("disable_notification")]
        public bool DisableNotification { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("from_background")]
        public bool FromBackground { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("input_message_contents")]
        public InputMessageContent[] InputMessageContents { get; set; }

    }

}
