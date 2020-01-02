using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using System.Diagnostics;
using System.Linq;

namespace IssueConsoleTemplateNet472
{
    public class IceCream
    {
        public int IceCreamId { get; set; }
        public string Name { get; set; }
    }

    public class Context : DbContext
    {
        public DbSet<IceCream> IceCreams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySql("server=127.0.0.1;port=3306;user=root;password=;database=Issue1003",
                    b => b.ServerVersion(new ServerVersion("10.4.11-mariadb")))
                .UseLoggerFactory(LoggerFactory.Create(b => b
                    .AddConsole()
                    .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IceCream>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(512)
                    .IsRequired();

                entity.HasData(
                    new IceCream { IceCreamId = 1, Name = "Vanilla" },
                    new IceCream { IceCreamId = 2, Name = "Chocolate" },
                    new IceCream { IceCreamId = 3, Name = "Strawberry" }
                );
            });
        }
    }

    internal class Program
    {
        private static void Main()
        {
            using (var context = new Context())
            {
                var iceCreams = context.IceCreams
                    .OrderBy(i => i.IceCreamId)
                    .ToList();

                Debug.Assert(iceCreams.Count == 3);
                Debug.Assert(iceCreams[0].Name == "Vanilla");
                Debug.Assert(iceCreams[0].IceCreamId == 1);
            }
        }
    }
}
