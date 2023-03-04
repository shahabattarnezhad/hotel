using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Infrastructure.Data
{
    public class ApplicationDbContextVersionTwo : DbContext
    {
        public ApplicationDbContextVersionTwo(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>().OwnsOne(c => c.Address);
        }

        public DbSet<ApplicationUser> ApplicationUsers => Set<ApplicationUser>();
        public DbSet<Booking> Bookins => Set<Booking>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<CustomerDetail> CustomerDetails => Set<CustomerDetail>();
        public DbSet<Room> Rooms => Set<Room>();
        public DbSet<RoomType> RoomTypes => Set<RoomType>();
        public DbSet<Payment> Payments => Set<Payment>();
        public DbSet<Prepayment> Prepayments => Set<Prepayment>();
    }
}
