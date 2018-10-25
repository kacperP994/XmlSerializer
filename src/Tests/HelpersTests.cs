using ConsoleApp1;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Controllers;
using TestProject.Models;
using Xunit;

namespace Tests
{
    public class HelpersTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        public void RandomGeneratorLengthTest(int length)
        {
            var generator = Substitute.For<BogusModelGenerator>();

            var result = generator.GetRandomRequests(length);
            Assert.Equal(result.Count(), length);
        }




    }
}
