using System.ComponentModel.DataAnnotations;

namespace ThaLeague.Models
{
    public class Audio
    {
        [Key]
        public int AudioId { get; set; }
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? Path { get; set; }
        public Artist? Artist { get; set; }
    }
}
