using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountryInfoApp.Models;

namespace CountryInfoApp.DAL
{
	internal class CountryInfoDbContext: DbContext
	{
		static CountryInfoDbContext()
		{
			Database.SetInitializer(new CountryInfoDbInitializer());
		}
		public CountryInfoDbContext() : base("CountryInfoDb")
		{

		}
		public DbSet<City> Cities { get; set; }
		public DbSet<Region> Regions { get; set; }
		public DbSet<Country> Countries { get; set; }
	}
}
