using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class GetPasswordState : Method<PasswordState>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "getPasswordState";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

    }

}
