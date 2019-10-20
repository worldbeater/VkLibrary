using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class UtilsGetLastShortenedLinksResponse
    {
        ///<summary>
        /// Total number of available results
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public UtilsLastShortenedLink[] Items { get; set; }
    }
}