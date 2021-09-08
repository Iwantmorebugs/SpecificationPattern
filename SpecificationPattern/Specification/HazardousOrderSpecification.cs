using System.Linq;

namespace SpecificationPattern.Specification
{
    public class HazardousOrderSpecification : Specification<Order>
    {
        public override bool IsSatisfiedBy(Order candidate)
        {
            return candidate.OrderItems.Count(item => item.ContainsHazardousMaterial) == 0;
        }
    }
}