using System;
using reviewsite.Controllers;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using reviewsite.Repositories;
using reviewsite.Model;

namespace reviewsite.Tests
{
    public class CategoryControllerTests
    {
            CategoryController underTest;
            IRepository<Category> categoryRepo;
        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = underTest.Details(1);

            Assert.IsType<ViewResult>(result);




        }


            [Fact]
            public void Index_Passes_All_Category_To_View()
            {
                var expectedCategories = new List<Category>();
                categoryRepo.GetAll().Returns(expectedCategories);

                var result = underTest.Index();

                Assert.Equal(expectedCategories, result.Model);
            }

           

            [Fact]
            public void Details_Passes_Category_To_View()
            {
                var expectedCategory = new Category();
                categoryRepo.GetById(1).return (expectedCategory);

                var result = underTest.Details(1);

                Assert.Equal(expectedCategory, result.Model);
            }
        }

