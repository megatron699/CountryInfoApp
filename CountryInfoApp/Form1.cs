using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CountryInfoApp.DAL;
using CountryInfoApp.Models;

namespace CountryInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void countryNameEnterButton_Click(object sender, EventArgs e)
        {
            var request = WebRequest.Create("https://restcountries.eu/rest/v2/name/" + countryNameTextBox.Text);
            request.Method = "GET";
            request.ContentType = "application/json";
            try
            {
                var dbContext= new CountryInfoDbContext();
                using (var response = request.GetResponse())
                {
                    string answer;
                    using (var stream = response.GetResponseStream())
                    {
                        using (var reader = new StreamReader(stream ?? throw new InvalidOperationException()))
                        {
                            answer = reader.ReadToEnd();
                        }
                    }

                    if (JsonConvert.DeserializeObject<List<City>>(answer).Count > 1)
                    {
	                    throw new Exception("Слишком много стран по данному запросу. Введите более точное название!");
                    }

					var capital = JsonConvert.DeserializeObject<List<City>>(answer)[0];
					var capitalInDb = dbContext.Cities.FirstOrDefault(c => c.Name == capital.Name);
					if (capitalInDb == null)
					{
						capital.Id = Guid.NewGuid();
						dbContext.Cities.Add(capital);
					}
					else
					{
						capital.Id = capitalInDb.Id;
					}

                    var region = JsonConvert.DeserializeObject<List<Region>>(answer)[0];
                    var regionInDb = dbContext.Regions.FirstOrDefault(r => r.Name == region.Name);
                    if (regionInDb == null)
                    {
                        region.Id = Guid.NewGuid();
						dbContext.Regions.Add(region);
                    }
                    else
                    {
	                    region.Id = regionInDb.Id;
                    }
                    

                    var country = JsonConvert.DeserializeObject<List<Country>>(answer)[0];
                    var countryInDb = dbContext.Countries
	                    .FirstOrDefault(c => c.Code == country.Code);
                    country.Region = region;
                    country.Capital = capital;
                    if (countryInDb == null)
                    {
                        country.Id = new Guid();
	                    dbContext.Countries.Add(country);
                    }
                    else
                    {
	                    dbContext.Countries.AddOrUpdate(country);
                    }
                    dbContext.SaveChanges();

                    countryInfoDataGridView.Rows.Add(country.Name, country.Code, country.Capital.Name,
                        country.Area, country.Population, country.Region.Name);
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Страны с таким именем не существует!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonSerializationException ex)
            {
                MessageBox.Show(
                    "Произошла ошибка при обработке информации о стране (Возможно, введено некорректное название)!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void countryInfoOutputButton_Click(object sender, EventArgs e)
        {
            var dbContext = new CountryInfoDbContext();
            var countriesInDb = dbContext.Countries
	            .Include(c => c.Capital)
	            .Include(c => c.Region);
            foreach (var country in countriesInDb)
            {
	            countryInfoDataGridView.Rows.Add(country.Name, country.Code, country.Capital.Name,
		            country.Area, country.Population, country.Region.Name);
            }
        }
    }
}
