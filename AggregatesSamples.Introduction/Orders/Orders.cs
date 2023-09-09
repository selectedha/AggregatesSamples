using AggregatesSamples.Introduction.AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregatesSamples.Introduction.Orders
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int AddressLineId { get; set; }

        private readonly List<OrderLine> _orderLines = new();

        public int GetTotalPrice()
        {
            return _orderLines.Where(p => p.OrderId == OrderId).Sum(p => p.GetTotalPrice());
        }

        public void ChangeCount(int newCount, int orderLineId)
        {
            
        }

        public Order(int addressLineId,  DateTime orderDate, List<OrderLine> orderLines)
        {
            if (addressLineId < 1)
                throw new ArgumentException();
            if(orderLines == null || !orderLines.Any())
                throw new ArgumentException();
            AddressLineId = addressLineId;
            OrderDate = orderDate;
            _orderLines = orderLines;
        }


    }
}
