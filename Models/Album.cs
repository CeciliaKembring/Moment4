using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SongAPI.Models 
{
    public class Album 
    {
        public int AlbumId { get; set; }
        
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Artist { get; set; }
        public DateTime? ReleaseDate { get; set; }
   
        public ICollection<Song>? Songs { get; set; }
    }
}
