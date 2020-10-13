using System.Net;

namespace CountryInfoApp.Helpers
{
	/// <summary>
	/// Представляет метод, создающий и возвращающий web-запрос.
	/// </summary>
	internal class RequestHelper
	{
		/// <summary>
		/// Создаёт web-запрос и возвращает его.
		/// </summary>
		/// <param name="countryName">Название страны.</param>
		/// <returns>web-запрос</returns>
		internal static WebRequest CreateRequest(string countryName)
		{
			var request = WebRequest.Create("https://restcountries.eu/rest/v2/name/" + countryName);
			request.Method = "GET";
			request.ContentType = "application/json";
			return request;
		}
	}
}
