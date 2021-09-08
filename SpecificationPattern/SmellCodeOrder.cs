using System.Collections.Generic;
using System.Linq;

namespace SpecificationPattern
{
    public class SmellCodeOrder
    {
        private readonly IEnumerable<Product> _orderItems;
        private readonly Address _address;
        public IEnumerable<Product> OrderItems => _orderItems;
        public Address ShippingAddress => _address;
        public int OrderTotal;

        public SmellCodeOrder(IEnumerable<Product> orderItems, Address address)
        {
            _orderItems = orderItems;
            _address = address;
        }

        public bool IsRush()
        {
            var isRush = false;
            if (ShippingAddress.Country == "USA")
            {
                if (OrderTotal > 100)
                {
                    if (_orderItems.Count(item => !item.IsInStock) == 0)
                    {
                        if (_orderItems.Count(item => item.ContainsHazardousMaterial) == 0)
                        {
                            isRush = true;
                        }
                    }
                }
            }

            return isRush;
        }
    }
}