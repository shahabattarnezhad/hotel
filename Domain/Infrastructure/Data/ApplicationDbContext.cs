using Domain.Models;
using Domain.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Domain.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = ./Infrastructure/Data/HotelDB.db");
        optionsBuilder.UseLazyLoadingProxies();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent Api

        modelBuilder.Entity<Customer>()
                    .OwnsOne(c => c.Address);
        
        modelBuilder.Entity<ApplicationUser>()
                    .HasKey(a => a.Id);

        modelBuilder.Entity<ApplicationUser>()
                    .Property(a => a.UserName)
                    .IsRequired()
                    .HasMaxLength(100);

        modelBuilder.Entity<ApplicationUser>()
                    .Property(a => a.Name)
                    .IsRequired()
                    .HasMaxLength(100);

        modelBuilder.Entity<Room>()
                    .HasOne<RoomType>(r => r.RoomType)
                    .WithMany(rt => rt.Rooms)
                    .HasForeignKey(r => r.RoomTypeId);
    }

    public DbSet<ApplicationUser>? ApplicationUsers { get; set; }
    public DbSet<Booking>? Bookings { get; set; }
    public DbSet<Customer>? Customers { get; set; }
    public DbSet<CustomerDetail>? CustomerDetails { get; set; }
    public DbSet<Room>? Rooms { get; set; }
    public DbSet<RoomType>? RoomTypes { get; set; }
    public DbSet<Payment>? Payments { get; set; }
    public DbSet<Prepayment>? Prepayments { get; set; }
}
