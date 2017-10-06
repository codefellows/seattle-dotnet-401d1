using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistSolution.Models
{
    public class Playlist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        ICollection<Song> Songs { get; set; }

    }
}
