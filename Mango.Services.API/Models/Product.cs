using System;
using System.ComponentModel.DataAnnotations;

namespace Mango.Services.API.Models
{
	public class Product
	{

		[Key]
		public int ProductId { get; set; }

		[Required]
		public object Name { get; set; }


		public string Description { get; set; }

		public string CategoryName { get; set; }

		public double Price { get; set; }

		public string ImageUrl { get; set; }

		public Product()
		{

		}
	}
}

