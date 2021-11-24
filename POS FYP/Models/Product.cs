namespace POS_FYP.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Purchase { get; set; }
        public int Retail { get; set; }
        public int Stock { get; set; }
        public string Barcode { get; set; }
        public string SKU { get; set; }
        public string Supplier { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
    }
}
