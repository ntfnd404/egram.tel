using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class DeleteSavedOrderInfo : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "deleteSavedOrderInfo";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

    }

}
