using AggregatesSamples.Introduction.AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregatesSamples.Introduction.Orders
{
    public class Orders
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        private readonly List<OrderLines> _orderLines = new();
        public IReadOnlyList<OrderLines> OrderLines => _orderLines;

        public int GetTotalPrice()
        {
            return _orderLines.Where(p => p.OrderId == OrderId).Sum(p => p.Price);
        }
    }
}
