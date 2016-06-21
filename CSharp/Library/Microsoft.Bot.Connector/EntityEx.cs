﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Bot.Connector
{
    public partial class Entity
    {
        [JsonExtensionData(ReadData = true, WriteData = true)]
        public JObject Properties { get; set; }

        /// <summary>
        /// Retrieve internal payload.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetAs<T>()
        {
            return Properties.ToObject<T>();
        }

        /// <summary>
        /// Set internal payload.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        public void SetAs<T>(T obj)
        {
            Properties = JObject.FromObject(obj);
        }
    }
}