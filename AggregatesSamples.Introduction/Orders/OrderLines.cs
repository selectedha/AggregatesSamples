namespace AggregatesSamples.Introduction.Orders
{
    public class OrderLines
    {
        public int LineId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
    }
}