using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class RemoveRecentSticker : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "removeRecentSticker";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("is_attached")]
        public bool IsAttached { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("sticker")]
        public InputFile Sticker { get; set; }

    }

}
