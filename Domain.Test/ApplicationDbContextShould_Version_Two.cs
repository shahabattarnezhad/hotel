using Castle.Core.Resource;
using Domain.Models;
using Domain.Utilities;

namespace Domain.Test
{
    public class ApplicationDbContextShould_Version_Two : DatabaseTest
    {
        public ApplicationDbContextShould_Version_Two()
        {
            _db.Database.EnsureCreated();
        }

        [Fact]
        public void AddApplicationUserSuccessTest()
        {
            var user = new ApplicationUser
            {
                Id = Guid.NewGuid(),
                Email = "george@gmail.com",
                IsActive = true,
                Name = "George Michael",
                Phone = "1234567890",
                UserName = "michael",
                Role = ApplicationRole.Admin
            };

            _db.ApplicationUsers.Add(user);
            _db.SaveChanges();

            Assert.True(_db.ApplicationUsers.Count() > 0);
        }

        [Fact]
        public void AddRoomTypeSuccessTest()
        {
            var roomType = new RoomType
            {
                Id = Guid.NewGuid(),
                Title = "Royal",
                Description = "Description Test For Royal Room Type",
                IsAvailable = true,
            };

            _db.RoomTypes.Add(roomType);
            _db.SaveChanges();

            Assert.True(_db.RoomTypes.Count() > 0);
        }

        [Fact]
        public void AddRoomSuccessTest()
        {
            var room = new Room
            {
                Id = Guid.NewGuid(),
                Title = "101",
                Description = "Description Test For room",
                Price = (decimal)20.99,
                Status = RoomStatus.Available,
                RoomType = new RoomType
                {
                    Id = Guid.NewGuid(),
                    Title = "2 beds",
                    Description = "test",
                    IsAvailable = true
                }
            };

            _db.Rooms.Add(room);
            _db.SaveChanges();

            Assert.True(_db.Rooms.Count() > 0);
            Assert.True(_db.RoomTypes.Count() > 1);
        }

        [Fact]
        public void AddCustomerSuccessTest()
        {
            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                Address = new Address("7th", "8596745869", "Vienna"),
                Category = CustomerCategory.Adult,
                Email = "smith@gmail.com",
                FirstName = "John",
                LastName = "Smith",
                Gender = Gender.Male,
                Phone = "012345678901",
                CustomerDetail = new CustomerDetail
                {
                    Id = Guid.NewGuid(),
                    InsuranceNumber= 125644,
                    SocialNumber = 63434354
                }
            };

            _db.Customers.Add(customer);
            _db.SaveChanges();

            Assert.True(_db.Customers.Count() > 0);
            Assert.True(_db.CustomerDetails.Count() > 0);
        }

        [Fact]
        public void AddPaymentSuccessTest()
        {
            var payment = new Payment();
            payment.Id = Guid.NewGuid();
            payment.PaymentTitle = "Mr. Smith has payed.";
            payment.CustomerId = new Guid("1794545D-D417-4B90-BC2E-000B8A0D35DC");
            payment.NightCount = Utility.CalculateNights(new DateTime(2023, 01, 01), new DateTime(2023, 01, 05));
            payment.PricePerNight = 20;
            payment.TotalNightPrice = Utility.CalculateNightPrices(payment.PricePerNight, payment.NightCount);
            payment.Tax = 10;
            payment.Total = Utility.CalculateTotalWithTax(payment.TotalNightPrice, payment.Tax);
            payment.PaymentDate = DateTime.Now;

            _db.Payments.Add(payment);
            _db.SaveChanges();

            Assert.True(_db.Payments.Count() > 0);
            Assert.Equal(88, payment.Total);
        }
    }
}
