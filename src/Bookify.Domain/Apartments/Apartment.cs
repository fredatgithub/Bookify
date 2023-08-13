using Bookify.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Apartments
{
    public class Apartment : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Country { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public decimal PriceAmount { get; private set; }
        public decimal PriceCurrency { get; private set; }
        public decimal CleaningFeeAmount { get; private set; }
        public decimal CleaningFeeCurrency { get; private set; }
        public DateTime? LastBookedOnUtc { get; private set; }
        public List<Amenity> Amenities { get; private set; }

        public Apartment(Guid id) : base(id)
        {
        }
    }
}
