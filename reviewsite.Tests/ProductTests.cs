using reviewsite.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace reviewsite.Tests
{
    public class ProductTests
    {
        
            Product underTest;

            public ProductTests()
            {
                underTest = new Product(42, "Course Name", "Description of course");
            }

            [Fact]
            public void ProductConstructor_Sets_Name_On_CourseModel()
            {
                var result = underTest.Name;

                Assert.Equal("Course Name", result);
            }

            [Fact]
            public void CourseConstructor_Sets_Id_On_CourseModel()
            {
                var result = underTest.Id;

                Assert.Equal(42, result);
            }

            [Fact]
            public void CourseConstructor_Sets_Description_On_CourseModel()
            {
                var result = underTest.Description;

                Assert.Equal("Description of course", result);
            }

        

    }
}
