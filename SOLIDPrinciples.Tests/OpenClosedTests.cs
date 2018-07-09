using SOLID._02_OpenClosed;
using Xunit;
using FluentAssertions;

namespace SOLIDPrinciples.Tests
{
    public class OpenClosedTests
    {
        [Fact]
        public void Validate()
        {
            var employee = new Employee(1, "Test", "Permanent");
            employee.CalculateBonus(1000).Should().Be(100);
        }
    }
}
