using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatMemberStatus : Structure
    {

        public class ChatMemberStatusMember : ChatMemberStatus
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatMemberStatusMember";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
