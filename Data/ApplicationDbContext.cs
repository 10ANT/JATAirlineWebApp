using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JATAirlineWebApp.Models;

namespace JATAirlineWebApp.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<JATAirlineWebApp.Models.Reservation> Reservation { get; set; } = default!;
	}
}