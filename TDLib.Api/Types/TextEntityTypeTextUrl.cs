using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TextEntityType : Structure
    {

        public class TextEntityTypeTextUrl : TextEntityType
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "textEntityTypeTextUrl";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("url")]
                public string Url { get; set; }

        }

    }

}
