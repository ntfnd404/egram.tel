using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InputMessageContent : Structure
    {

        public class InputMessageSticker : InputMessageContent
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputMessageSticker";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker")]
                public InputFile Sticker { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail")]
                public InputThumbnail Thumbnail { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("width")]
                public int Width { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("height")]
                public int Height { get; set; }

        }

    }

}
