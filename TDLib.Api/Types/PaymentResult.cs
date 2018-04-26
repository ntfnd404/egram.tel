using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class PaymentResult : Structure
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "paymentResult";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("verification_url")]
        public string VerificationUrl { get; set; }

    }

}
