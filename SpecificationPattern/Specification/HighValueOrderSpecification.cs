namespace SpecificationPattern.Specification
{
    public class HighValueOrderSpecification : Specification<Order>
    {
        public override bool IsSatisfiedBy(Order candidate)
        {
            return candidate.OrderTotal > 100;
        }
    }
}