namespace ThaLeague.ViewModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public List<string> Sizes { get; set; } = new List<string>();
        public List<string> Material { get; set; } = new List<string>();
        public int InventoryCount { get; set; }
        public IFormFile? Image1 { get; set; }
        public IFormFile? Image2 { get; set; }
        public IFormFile? Image3 { get; set; }
    }
}
