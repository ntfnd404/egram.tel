using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class UserStatus : Structure
    {

        public class UserStatusEmpty : UserStatus
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "userStatusEmpty";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
