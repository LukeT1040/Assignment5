using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Assignment5.Models
{
    public class SongGenreViewModel
    {
        public List<Songs> Songs { get; set; }
        public SelectList? Genres { get; set; }
        public string? SongGenre { get; set; }

        public SelectList? Artists { get; set; }

        public string? SongArtist { get; set; }

    }
}
