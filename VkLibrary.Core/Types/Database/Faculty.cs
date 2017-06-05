using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Database
{
    public class Faculty
    {
        /// <summary>
        /// Faculty ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Faculty title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}