using System;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.API.ApplicationDBContext
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
		{

		}
	


	}
}

