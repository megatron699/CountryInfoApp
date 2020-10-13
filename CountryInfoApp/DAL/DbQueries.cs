using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CountryInfoApp.Models;
using Newtonsoft.Json;

namespace CountryInfoApp.DAL
{
	/// <summary>
	/// Представляет методы работы с БД.
	/// </summary>
	internal class DbQueries
	{
		private readonly CountryInfoDbContext _dbContext = new CountryInfoDbContext();

		/// <summary>
		/// Добавляет страну в БД.
		/// </summary>
		/// <param name="countryFromApi">Страна, полученная через Api</param>
		/// <param name="capital">Столица</param>
		/// <param name="region">Регион</param>
		internal void AddCountryInDb(CountryFromApi countryFromApi, City capital, Region region)
		{
			var countryInDb = _dbContext.Countries
				.FirstOrDefault(c => c.Code == countryFromApi.Code);
			if (countryInDb == null)
			{
				var country = new Country
				{
					Id = Guid.NewGuid(),
					Name = countryFromApi.Name,
					Code = countryFromApi.Code,
					Capital = capital,
					Area = countryFromApi.Area,
					Population = countryFromApi.Population,
					Region = region,
				};
				_dbContext.Countries.Add(country);
			}
			else
			{
				countryInDb.Name = countryFromApi.Name;
				countryInDb.Code = countryFromApi.Code;
				countryInDb.Capital = capital;
				countryInDb.Area = countryFromApi.Area;
				countryInDb.Population = countryFromApi.Population;
				countryInDb.Region = region;
			}

			_dbContext.SaveChanges();
		}

		/// <summary>
		/// Возвращает коллекцию стран из БД.
		/// </summary>
		/// <returns>Коллекция стран.</returns>
		internal IQueryable<Country> GetCountriesFromDb()
		{
			return _dbContext.Countries
				.Include(c => c.Capital)
				.Include(c => c.Region);
		}

		/// <summary>
		/// Возвращает столицу, полученную через API.
		/// </summary>
		/// <param name="answer">Строка JSON, полученная через API.</param>
		/// <returns>Столица.</returns>
		internal City GetCapital(string answer)
		{
			var capital = JsonConvert.DeserializeObject<List<City>>(answer)[0];
			var capitalInDb = _dbContext.Cities.FirstOrDefault(c => c.Name == capital.Name);
			if (capitalInDb == null)
			{
				capital.Id = Guid.NewGuid();
				_dbContext.Cities.Add(capital);
			}
			else
			{
				capital = capitalInDb;
			}

			return capital;
		}

		/// <summary>
		/// Возвращает регион страны, полученной через API.
		/// </summary>
		/// <param name="answer">Строка JSON, полученная через API.</param>
		/// <returns>Регион.</returns>
		internal Region GetRegion(string answer)
		{
			var region = JsonConvert.DeserializeObject<List<Region>>(answer)[0];
			var regionInDb = _dbContext.Regions.FirstOrDefault(r => r.Name == region.Name);
			if (regionInDb == null)
			{
				region.Id = Guid.NewGuid();
				_dbContext.Regions.Add(region);
			}
			else
			{
				region = regionInDb;
			}

			return region;
		}
	}
}