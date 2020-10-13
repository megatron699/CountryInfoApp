using System.Collections.Generic;
using Newtonsoft.Json;

namespace CountryInfoApp
{
	/// <summary>
	/// Объект Страна, полученный из API.
	/// </summary>
	[JsonObject(MemberSerialization.OptIn)]
	internal class CountryFromApi
	{
		/// <summary>
		/// Название страны.
		/// </summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		/// <summary>
		/// Код страны.
		/// </summary>
		[JsonProperty(PropertyName = "alpha2Code")]
		public string Code { get; set; }

		/// <summary>
		/// Столица.
		/// </summary>
		[JsonProperty(PropertyName = "capital")]
		public string Capital { get; set; }

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
		[JsonProperty(PropertyName = "region")]
		public string Region { get; set; }

		/// <summary>
		/// Возвращает десереализованный из строки JSON объект Страна.
		/// </summary>
		/// <param name="answer">Строка JSON, полученная через API.</param>
		/// <returns>Объект Страна.</returns>
		internal static CountryFromApi GetCountryFromApi(string answer)
		{
			return JsonConvert.DeserializeObject<List<CountryFromApi>>(answer)[0];
		}
    }
}
