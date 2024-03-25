using BlazorCrudLibros.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudLibros.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public DbSet<Libro> Libro { get; set; }
	}
}
