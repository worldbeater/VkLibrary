using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class BaseMessageError
    {
        ///<summary>
        /// Error code
        ///</summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        ///<summary>
        /// Error message
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }
    }
}