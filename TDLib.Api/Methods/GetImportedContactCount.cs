using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class GetImportedContactCount : Method<Count>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "getImportedContactCount";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

    }

}
