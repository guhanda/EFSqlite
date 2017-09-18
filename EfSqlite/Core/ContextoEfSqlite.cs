using EfSqlite.Core.Entidades;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace EfSqlite.Core
{
    class ContextoEfSqlite : DbContext
    {
        public DbSet<Pedido> Pedido { get; set; }

        private static bool _created = false;

        public ContextoEfSqlite()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder() { DataSource = "test.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }
    }
}
