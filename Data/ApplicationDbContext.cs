using _31241022342_TrinhMinhPhat.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _31241022342_TrinhMinhPhat.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
{public DbSet<Movie> Movies { get; set; }
public DbSet<Genre> Genres { get; set; }

public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
public DbSet<HoaDon> HoaDons { get; set; }
public DbSet<ShippingDetail> ShippingDetails { get; set; }
}