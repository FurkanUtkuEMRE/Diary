using Microsoft.EntityFrameworkCore;
using DiaryApp.Models;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntryModel>().HasData(
                new DiaryEntryModel
                {
                    Id = 1,
                    Title = "Went hiking!",
                    Content = "We went hiking with Rain!",
                    Date = DateTime.Now
                },
                new DiaryEntryModel
                {
                    Id = 2,
                    Title = "Worked on Anima.",
                    Content = "I worked on my game...",
                    Date = DateTime.Now
                },
                new DiaryEntryModel
                {
                    Id = 3,
                    Title = "Played tennis!",
                    Content = "We played tennis with Rain!",
                    Date = DateTime.Now
                }
            );
        }

        public DbSet<DiaryEntryModel> DiaryEntries { get; set; }
    }
}
