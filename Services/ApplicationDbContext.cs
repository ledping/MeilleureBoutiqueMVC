using MeilleureBoutiqueMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MeilleureBoutiqueMVC.Services
{
		public class ApplicationDbContext : DbContext
		{
			public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
			{
			}

		public DbSet<Product> Products { get; set; }
	}
}

