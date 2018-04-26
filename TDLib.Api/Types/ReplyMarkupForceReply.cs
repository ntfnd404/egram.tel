using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ReplyMarkup : Structure
    {

        public class ReplyMarkupForceReply : ReplyMarkup
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "replyMarkupForceReply";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_personal")]
                public bool IsPersonal { get; set; }

        }

    }

}
