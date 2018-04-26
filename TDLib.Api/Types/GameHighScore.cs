using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class GameHighScore : Structure
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "gameHighScore";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("score")]
        public int Score { get; set; }

    }

}
