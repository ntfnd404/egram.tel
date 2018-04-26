using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatEventAction : Structure
    {

        public class ChatEventStickerSetChanged : ChatEventAction
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventStickerSetChanged";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("old_sticker_set_id")]
                public Int64 OldStickerSetId { get; set; }

                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("new_sticker_set_id")]
                public Int64 NewStickerSetId { get; set; }

        }

    }

}