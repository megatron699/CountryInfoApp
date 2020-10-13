using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CountryInfoApp.Models
{
    /// <summary>
    /// Представляет сущность City.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    internal class City
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        [JsonProperty(PropertyName = "capital")]
        public string Name { get; set; }

    }
}
