using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class SetNetworkType : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "setNetworkType";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("type")]
        public NetworkType Type { get; set; }

    }

}
