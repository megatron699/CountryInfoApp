using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CountryInfoApp.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class Country
    {
        [Key]
        public Guid Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "alpha2Code")]
        public string Code { get; set; }
        public City Capital { get; set; }
        [JsonProperty(PropertyName = "area")]
        public double Area { get; set; }
        [JsonProperty(PropertyName = "population")]
        public int Population { get; set; }
        public Region Region { get; set; }

        public Country()
        {
            Id = Guid.NewGuid();
        }
    }
}
