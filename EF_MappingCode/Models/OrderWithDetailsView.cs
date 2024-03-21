namespace EF_MappingCode.Models
{
    // it's a view in the DataBase and i will access it 
    public class OrderWithDetailsView
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerEmail { get; set; } = string.Empty;
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public override string ToString()
        {
            return
                $"#{OrderId}: {OrderDate}, {ProductName} X {Quantity} @ {UnitPrice.ToString("C")}";
        }
    }
}
