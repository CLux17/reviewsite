using System;
using reviewsite.Controllers;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace reviewsite.Tests
{
    public class CateogryControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            //var underTest = new CategoryController();

            //var result = underTest.Index();

            //Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            //var undertest = new CategoryController();

            //var result = undertest.Details(1);

            //Assert.IsType<ViewResult>(result);




        }

        public class CourseControllerTests
        {
            CourseController underTest;
            IRepository<Course> courseRepo;

            public CourseControllerTests()
            {
                courseRepo = Substitute.For<IRepository<Course>>();
                underTest = new CourseController(courseRepo);
            }

            [Fact]
            public void Index_Returns_A_View()
            {
                var result = underTest.Index();

                Assert.IsType<ViewResult>(result);
            }

            [Fact]
            public void Index_Passes_All_Courses_To_View()
            {
                var expectedCourses = new List<Course>();
                courseRepo.GetAll().Returns(expectedCourses);

                var result = underTest.Index();

                Assert.Equal(expectedCourses, result.Model);
            }

            [Fact]
            public void Details_Returns_A_View()
            {
                var result = underTest.Details(1);

                Assert.IsType<ViewResult>(result);
            }

            [Fact]
            public void Details_Passes_Course_To_View()
            {
                var expectedCourse = new Course();
                courseRepo.GetById(1).Returns(expectedCourse);

                var result = underTest.Details(1);

                Assert.Equal(expectedCourse, result.Model);
            }
        }
}
