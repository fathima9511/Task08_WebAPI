namespace Task08_WebAPI.Model
{
    public class AddProductRequest
    {
        public string ProductName { get; set; }
        public string Availability { get; set; }
        public string Brand { get; set; }

        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
