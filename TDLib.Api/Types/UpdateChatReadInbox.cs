using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public class UpdateChatReadInbox : Update
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateChatReadInbox";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long ChatId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("last_read_inbox_message_id")]
                public long LastReadInboxMessageId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("unread_count")]
                public int UnreadCount { get; set; }

        }

    }

}
