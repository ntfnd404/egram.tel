using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class GetInviteText : Method<Text>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "getInviteText";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

    }

}
