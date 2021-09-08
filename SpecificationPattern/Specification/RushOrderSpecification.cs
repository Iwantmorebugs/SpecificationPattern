namespace SpecificationPattern.Specification
{
    public class RushOrderSpecification : Specification<Order>
    {
        private readonly DomesticOrderSpecification domesticOrderSpecification = new();
        private readonly HazardousOrderSpecification hazardousOrderSpecification = new();
        private readonly HighValueOrderSpecification highValueOrderSpecification = new();
        private readonly IsInStockSpecification isInStockSpecification = new();

        public override bool IsSatisfiedBy(Order candidate)
        {
            return domesticOrderSpecification
                .And(hazardousOrderSpecification)
                .And(isInStockSpecification)
                .And(highValueOrderSpecification)
                .IsSatisfiedBy(candidate);
        }
    }
}