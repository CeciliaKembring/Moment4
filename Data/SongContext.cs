using SongAPI.Models; 
using Microsoft.EntityFrameworkCore;

namespace SongAPI.Data{
    public class SongContext : DbContext {
        public SongContext(DbContextOptions<SongContext> options) : base(options)
        {

        }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Album {get; set; }
    }
}
