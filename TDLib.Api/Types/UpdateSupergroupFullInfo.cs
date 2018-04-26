using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public class UpdateSupergroupFullInfo : Update
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateSupergroupFullInfo";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("supergroup_id")]
                public int SupergroupId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("supergroup_full_info")]
                public SupergroupFullInfo SupergroupFullInfo { get; set; }

        }

    }

}
