using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InlineQueryResult : Structure
    {

        public class InlineQueryResultSticker : InlineQueryResult
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inlineQueryResultSticker";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string Id { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker")]
                public Sticker Sticker { get; set; }

        }

    }

}
