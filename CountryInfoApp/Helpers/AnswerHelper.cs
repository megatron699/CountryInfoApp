using System;
using System.IO;
using System.Net;

namespace CountryInfoApp.Helpers
{
	/// <summary>
	/// Представляет метод, возвращающий строку JSON, полученную через API. 
	/// </summary>
	internal class AnswerHelper
	{
		/// <summary>
		/// Возвращает строку JSON, полученную через API.
		/// </summary>
		/// <param name="response">Ответ сервера.</param>
		/// <returns>Строка JSON, полученная через API.</returns>
		internal static string GetAnswer(WebResponse response)
		{
			using (var stream = response.GetResponseStream())
			{
				using (var reader = new StreamReader(stream ?? throw new InvalidOperationException()))
				{
					var answer = reader.ReadToEnd();
					return answer;
				}
			}
		}
	}
}
