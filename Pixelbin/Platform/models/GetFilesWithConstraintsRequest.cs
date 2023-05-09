// Platform Models.
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using static Pixelbin.Platform.Enums;

namespace Pixelbin.Platform.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    internal class GetFilesWithConstraintsRequest
    {
        
        public List<GetFilesWithConstraintsItem>? items { get; set; }
        public float? maxCount { get; set; }
        public float? maxSize { get; set; }

        public override string ToString() {
            return JsonConvert.SerializeObject(this);
        }
    }
}