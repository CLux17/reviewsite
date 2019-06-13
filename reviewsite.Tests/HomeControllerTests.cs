using System;
using reviewsite.Controllers;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace reviewsite.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_Hello_World()
        {
            var underTest = new HomeController();

            var result = underTest.Index();

            Assert.Equal("Hello world!", result);
        }
    }
}
