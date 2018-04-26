using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatEventAction : Structure
    {

        public class ChatEventMemberPromoted : ChatEventAction
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventMemberPromoted";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public int UserId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("old_status")]
                public ChatMemberStatus OldStatus { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("new_status")]
                public ChatMemberStatus NewStatus { get; set; }

        }

    }

}
