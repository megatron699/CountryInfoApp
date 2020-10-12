using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CountryInfoApp.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class Region
    {
        [Key]
        public Guid Id { get; set; }
        [JsonProperty(PropertyName = "region")]
        public string Name { get; set; }

        public Region()
        {
            Id = Guid.NewGuid();
        }
    }
}
