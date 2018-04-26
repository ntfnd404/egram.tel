using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class UserType : Structure
    {

        public class UserTypeUnknown : UserType
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "userTypeUnknown";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
