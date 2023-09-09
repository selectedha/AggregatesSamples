namespace AggregatesSamples.Introduction.Orders
{
    public class OrderLine
    {
        public int LineId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public void ChangeCount(int NewCount)
        {
            if (NewCount < 1)
                throw new ArgumentException();
            Count = NewCount;
        }

        public int GetTotalPrice() => Price * Count;
    }
}