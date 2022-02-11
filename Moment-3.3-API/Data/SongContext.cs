
using Microsoft.EntityFrameworkCore;
using Moment_3._3_API.Models;

namespace Moment_3._3_API.Data
{
    public class SongContext : DbContext
    {

        public SongContext(DbContextOptions options) : base(options) 

        {

        }  

        public DbSet<Song> songs { get; set; }
    }
}
