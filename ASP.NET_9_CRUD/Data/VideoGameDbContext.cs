using Microsoft.EntityFrameworkCore;

namespace ASP.NET_9_CRUD.Data
{
    public class VideoGameDbContext(DbContextOptions<VideoGameDbContext> options): DbContext(options)
    {
        //public DbSet<VideoGame> VideoGames { get; set; }   //define like this: VideoGames could be null
        public DbSet<VideoGame> VideoGames => Set<VideoGame>();  //VideoGames  --> name of table

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VideoGame>().HasData(

                  new VideoGame
                  {
                      Id = 1,
                      Title = "Test",
                      Platform = "PS5",
                      Developer = "Seanghor",
                      Publisher = "Sony Interactive Entertainment"
                  },
                   new VideoGame
                   {
                       Id = 2,
                       Title = "Adventure Quest",
                       Platform = "PS4",
                       Developer = "Game Studio",
                       Publisher = "Big Games Inc."
                   },
                    new VideoGame
                    {
                        Id = 3,
                        Title = "Battle Royale",
                        Platform = "PC",
                        Developer = "Epic Developers",
                        Publisher = "Super Games Co."
                    },
                    new VideoGame
                    {
                        Id = 4,
                        Title = "Racing Rivals",
                        Platform = "Xbox",
                        Developer = "SpeedWorks",
                        Publisher = "Turbo Media"
                    }
                );
        }
    }
}
