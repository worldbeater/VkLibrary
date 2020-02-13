using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Callback
{
    public class CallbackMessageBase
    {
        [JsonProperty("type")]
        public CallbackMessageType Type { get; set; }
        [JsonProperty("object")]
        public Object Object { get; set; }
        [JsonProperty("group_id")]
        public int GroupId { get; set; }
    }
}