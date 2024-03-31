using System.ComponentModel.DataAnnotations;

namespace SongAPI.Models 
{
    public class Song 
    {
        public int SongId { get; set; }
        
        [Required]
        public string? Title { get; set; }
        
        public string? Length { get; set; }
        
        [Required]
        public string? Category { get; set; }

        [Required]
        public int? AlbumId { get; set; }

        public Album? Album { get; set; }
    }
}
