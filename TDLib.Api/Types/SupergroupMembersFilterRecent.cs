using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class SupergroupMembersFilter : Structure
    {

        public class SupergroupMembersFilterRecent : SupergroupMembersFilter
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "supergroupMembersFilterRecent";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
