using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class FileType : Structure
    {

        public class FileTypeAnimation : FileType
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "fileTypeAnimation";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
