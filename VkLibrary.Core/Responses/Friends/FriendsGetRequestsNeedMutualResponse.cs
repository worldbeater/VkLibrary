using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class FriendsGetRequestsNeedMutualResponse
    {
        ///<summary>
        /// Total requests number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public FriendsRequests[] Items { get; set; }
    }
}