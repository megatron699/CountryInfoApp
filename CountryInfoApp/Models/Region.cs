using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CountryInfoApp.Models
{
	/// <summary>
    /// Представляет сущность БД Region.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    internal class Region
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Name { get; set; }

    }
}
