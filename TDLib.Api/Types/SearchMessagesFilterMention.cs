using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class SearchMessagesFilter : Structure
    {

        public class SearchMessagesFilterMention : SearchMessagesFilter
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "searchMessagesFilterMention";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}