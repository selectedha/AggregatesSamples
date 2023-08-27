using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregatesSamples.Introduction.AddressBook
{
    public class AddressBook
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }        
        private readonly List<AddressLine> _addressLines = new();
        public IReadOnlyList<AddressLine> AddressLines => _addressLines;

        public void AddAddressLine(string address, string city, bool isDefault)
        {
            AddressLine addressLine = new AddressLine
            {
                City = city,
                IsDefault = isDefault,
                Address = address
            };
            if(isDefault )
            {
                foreach (var Ad in _addressLines)
                {
                    Ad.IsDefault = false;
                }
            }

            _addressLines.Add(addressLine);
        }

        public AddressLine GeDefualt()
        {
            return AddressLines.Where(p => p.IsDefault).Single();
        }
    }
}
