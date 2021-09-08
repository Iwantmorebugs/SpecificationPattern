using System.Collections.Generic;
using FluentAssertions;
using SpecificationPattern;
using Xunit;

namespace OrderTests
{
    public class OrderTests
    {
        [Fact]
        public void IsRush_should_be_false_when_totalCost_is_50_and_country_is_USA_and_no_HazardousItems()
        {
            var sut = new Order(new List<Product>(), new Address(){Country = "USA"});
            sut.OrderTotal = 50;

            var result = sut.IsRush();

            result.Should().BeFalse();
        }

        [Fact]
        public void IsRush_should_be_false_when_totalCost_is_150_and_country_is_France_and_no_HazardousItems()
        {
            var sut = new Order(new List<Product>(), new Address() {Country = "FRANCE"}) {OrderTotal = 150};

            var result = sut.IsRush();

            result.Should().BeFalse();
        }

        [Fact]
        public void IsRush_should_be_false_when_totalCost_is_150_and_country_is_USA_and_there_is_HazardousItems()
        {
            var sut = new Order(new List<Product>(){new(){ContainsHazardousMaterial = true}}, address: new Address() { Country = "USA" });
            sut.OrderTotal = 150;

            var result = sut.IsRush();

            result.Should().BeFalse();
        }

        [Fact]
        public void IsRush_should_be_true_when_totalCost_is_150_and_country_is_USA_and_no_HazardousItems()
        {
            var sut = new Order(new List<Product>() { new() { ContainsHazardousMaterial = false } }, address: new Address() { Country = "USA" });
            sut.OrderTotal = 150;

            var result = sut.IsRush();

            result.Should().BeFalse();
        }
    }
}
