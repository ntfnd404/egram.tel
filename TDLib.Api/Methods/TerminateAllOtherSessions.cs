using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class TerminateAllOtherSessions : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "terminateAllOtherSessions";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

    }

}
