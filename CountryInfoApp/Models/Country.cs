using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CountryInfoApp.Models
{
    /// <summary>
    /// Представляет сущность БД Country.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    internal class Country
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Код страны.
        /// </summary>
        [JsonProperty(PropertyName = "alpha2Code")]
        public string Code { get; set; }

        /// <summary>
        /// Столица
        /// </summary>
        public City Capital { get; set; }

        /// <summary>
        /// Площадь.
        /// </summary>
        [JsonProperty(PropertyName = "area")]
        public double Area { get; set; }

        /// <summary>
        /// Население.
        /// </summary>
        [JsonProperty(PropertyName = "population")]
        public int Population { get; set; }

        /// <summary>
        /// Регион.
        /// </summary>
        public Region Region { get; set; }
    }
}
