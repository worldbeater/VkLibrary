using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class DocsDocUploadResponse
    {
        ///<summary>
        /// Uploaded file data
        ///</summary>
        [JsonProperty("file")]
        public String File { get; set; }
    }
}