// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Set of key-value pairs. Advantage of this section is that key and
    /// value properties will be
    /// rendered with default style information with some delimiter between
    /// them. So there is no need for developer to specify style information.
    /// </summary>
    public partial class Fact
    {
        /// <summary>
        /// Initializes a new instance of the Fact class.
        /// </summary>
        public Fact() { }

        /// <summary>
        /// Initializes a new instance of the Fact class.
        /// </summary>
        public Fact(string key = default(string), string value = default(string))
        {
            Key = key;
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
