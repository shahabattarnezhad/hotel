using Domain.Infrastructure.Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Domain.Test
{
    public class DatabaseTest : IDisposable
    {
        private readonly SqliteConnection _connection;
        protected readonly ApplicationDbContextVersionTwo _db;

        public DatabaseTest()
        {
            _connection = new SqliteConnection("DataSource=HotelDbTest.db");
            _connection.Open();

            var opt = new DbContextOptionsBuilder()
                .UseSqlite(_connection)
                .UseLazyLoadingProxies()
                .LogTo(message => Debug.WriteLine(message), Microsoft.Extensions.Logging.LogLevel.Information)
                .EnableSensitiveDataLogging()
                .Options;

            _db = new ApplicationDbContextVersionTwo(opt);
        }

        public void Dispose()
        {
            _db.Dispose();
            _connection.Dispose();
        }
    }
}
