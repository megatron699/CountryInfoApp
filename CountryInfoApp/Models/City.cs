using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CountryInfoApp.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class City
    {
        [Key]
        public Guid Id { get; set; }
        [JsonProperty(PropertyName = "capital")]
        public string Name { get; set; }

    }
}
