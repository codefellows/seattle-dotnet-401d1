using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistSolution.Models
{
    public class PlaylistsSongs
    {
        [Key]
        public int playlistID { get; set; }
        [Key]
        public int songID { get; set; }

        public Playlist Playlist { get; set; }
        public Song Song { get; set; }
    }
}
