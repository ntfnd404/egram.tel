using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public class UpdateNotificationSettings : Update
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateNotificationSettings";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("scope")]
                public NotificationSettingsScope Scope { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("notification_settings")]
                public NotificationSettings NotificationSettings { get; set; }

        }

    }

}
