using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlaylistSolution.Models;

namespace PlaylistSolution.Models
{
    public class PlaylistSolutionContext : DbContext
    {
        public PlaylistSolutionContext (DbContextOptions<PlaylistSolutionContext> options)
            : base(options)
        {
        }

        public DbSet<PlaylistSolution.Models.Playlist> Playlist { get; set; }

        public DbSet<PlaylistSolution.Models.Song> Song { get; set; }

        public DbSet<PlaylistsSongs> PlaylistSongs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PlaylistsSongs>().HasKey(table => new
            {
                table.playlistID,
                table.songID
            });
        }
    }
}
