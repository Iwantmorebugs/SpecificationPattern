namespace SpecificationPattern.Specification
{
    public abstract class CompositeSpecification<T> : Specification<T>
    {
        protected readonly ISpecification<T> _left;
        protected readonly ISpecification<T> _right;

        protected CompositeSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            _left = left;
            _right = right;
        }
    }
}