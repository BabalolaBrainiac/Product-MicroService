using System;
using Mango.Services.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.API.ApplicationDBContext
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
		{

		}

		public DbSet<Product> Products { get; set; }

	}
}

