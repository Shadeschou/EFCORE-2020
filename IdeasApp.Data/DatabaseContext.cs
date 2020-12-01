using IdeasApp.Domain;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Logging;

namespace IdeasApp.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Idea> Ideas { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CostSaving> CostSavings { get; set; }
        public DbSet<IdeaStatus> IdeaStatuses { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagIdea> TagIdeas { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserIdea> UserIdeas { get; set; }
        public DbSet<UserStatus> UserStatuses { get; set; }

        public static readonly ILoggerFactory ConsoleLoggerFactory
            = LoggerFactory.Create(builder =>
            {
                builder
                    .AddFilter((category, level) =>
                        category == DbLoggerCategory.Database.Command.Name
                        && level == LogLevel.Information);
            });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = IdeasAppData");
            }
        }

        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
    }


}