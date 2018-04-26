using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatAction : Structure
    {

        public class ChatActionRecordingVoiceNote : ChatAction
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatActionRecordingVoiceNote";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
