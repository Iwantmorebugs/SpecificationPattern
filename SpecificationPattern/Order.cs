using System.Collections.Generic;
using System.Linq;
using SpecificationPattern.Specification;

namespace SpecificationPattern
{
    public class Order
    {
        private readonly IEnumerable<Product> _orderItems;
        private readonly Address _address;
        public IEnumerable<Product> OrderItems => _orderItems;
        public Address ShippingAddress => _address;
        public int OrderTotal;

        public Order(IEnumerable<Product> orderItems, Address address)
        {
            _orderItems = orderItems;
            _address = address;
        }

        
        public bool IsRush()
        {
            var spec = new RushOrderSpecification();
            return spec.IsSatisfiedBy(this);
        }
    }
}