using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryInfoApp.DAL
{
	internal class CountryInfoDbInitializer: DropCreateDatabaseIfModelChanges<CountryInfoDbContext>
	{
		
	}
}
