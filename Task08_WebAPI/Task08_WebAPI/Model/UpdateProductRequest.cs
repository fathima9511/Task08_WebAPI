namespace Task08_WebAPI.Model
{
    public class UpdateProductRequest
    {
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string Availability { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
