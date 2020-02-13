using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Widgets
{
    public class WidgetsCommentMedia
    {
        ///<summary>
        /// Media item ID
        ///</summary>
        [JsonProperty("item_id")]
        public int ItemId { get; set; }

        ///<summary>
        /// Media owner's ID
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        ///<summary>
        /// URL of the preview image (type=photo only)
        ///</summary>
        [JsonProperty("thumb_src")]
        public String ThumbSrc { get; set; }
        [JsonProperty("type")]
        public WidgetsCommentMediaType Type { get; set; }
    }
}