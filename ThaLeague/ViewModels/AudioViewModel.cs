using System.ComponentModel.DataAnnotations;
using ThaLeague.Models;

namespace ThaLeague.ViewModels
{
    public class AudioViewModel
    {
        [Key]
        public int AudioId { get; set; }
        public string? Image { get; set; }
        public string? Title { get; set; }
        public IFormFile? Path { get; set; }
        public Artist? Artist { get; set; }
    }
}
