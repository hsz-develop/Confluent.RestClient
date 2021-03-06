﻿using Newtonsoft.Json;

namespace Confluent.RestClient.Model
{
    public class BinaryMessage : Message
    {
        /// <summary>
        /// The message key
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// The message value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}
