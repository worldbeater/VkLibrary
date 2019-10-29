using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class GroupsGetCatalogInfoResponse
    {
        ///<summary>
        /// Information whether catalog is enabled for current user
        ///</summary>
        [JsonProperty("enabled")]
        public int Enabled { get; set; }
        [JsonProperty("categories")]
        public GroupsGroupCategory[] Categories { get; set; }
    }
}