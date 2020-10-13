using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using CountryInfoApp.DAL;
using CountryInfoApp.Helpers;
using CountryInfoApp.Models;

namespace CountryInfoApp
{
	public partial class CountryInfoAppForm : Form
	{
		public CountryInfoAppForm()
		{
			InitializeComponent();
		}

		private void countryNameEnterButton_Click(object sender, EventArgs e)
		{
			countryInfoDataGridView.Rows.Clear();
			var request = RequestHelper.CreateRequest(countryNameTextBox.Text);
			try
			{
				using (var response = request.GetResponse())
				{
					var answer = AnswerHelper.GetAnswer(response);

					if (JsonConvert.DeserializeObject<List<City>>(answer).Count > 1)
					{
						throw new ArgumentOutOfRangeException(
							"Слишком много стран по данному запросу. Введите более точное название!");
					}

					var countryFromApi = CountryFromApi.GetCountryFromApi(answer);
					countryInfoDataGridView.Rows.Add(countryFromApi.Name, 
						countryFromApi.Code, 
						countryFromApi.Capital,
						countryFromApi.Area, 
						countryFromApi.Population, 
						countryFromApi.Region);

					var dialogResult = MessageBox.Show("Хотите ли сохранить город в базу данных?", 
						"",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question);
					if (dialogResult == DialogResult.Yes)
					{
						var query = new DbQueries();
						var capital = query.GetCapital(answer);
						var region = query.GetRegion(answer);
						query.AddCountryInDb(countryFromApi, capital, region);
					}
				}
			}
			catch (WebException ex)
			{
				MessageBox.Show("Страны с таким именем не существует!", 
					"Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			catch (JsonSerializationException ex)
			{
				MessageBox.Show(
					"Произошла ошибка при обработке информации о стране (Возможно, введено некорректное название)!",
					"Ошибка", 
					MessageBoxButtons.OK, 
					MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, 
					"Ошибка",
					MessageBoxButtons.OK, 
					MessageBoxIcon.Error);
			}
		}

		private void countryInfoOutputButton_Click(object sender, EventArgs e)
		{
			countryInfoDataGridView.Rows.Clear();
			var query = new DbQueries();
			var countriesInDb = query.GetCountriesFromDb();
			foreach (var country in countriesInDb)
			{
				countryInfoDataGridView.Rows.Add(country.Name, 
					country.Code, 
					country.Capital.Name,
					country.Area, 
					country.Population, 
					country.Region.Name);
			}
			
		}
	}
}