using System;
using reviewsite.Controllers;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NSubstitute;
using Microsoft.AspNetCore.Mvc;
using reviewsite.Repositories;
using reviewsite.Model;

namespace reviewsite.Tests
{
    public class ReviewControllerTests
    {
        ReviewController underTest;
        IRepository<Review> reviewRepo;

        public ReviewControllerTests()
        {
            reviewRepo = Substitute.For<IRepository<Review>>();
            underTest = new ReviewController(reviewRepo);
        }

        [Fact]
        public void Create_Returns_A_View()
        {
            var result = underTest.Create(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Delete_Returns_A_View()
        {
            var result = underTest.Delete(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Edit_Returns_A_View()
        {
            var result = underTest.Edit(1);

            Assert.IsType<ViewResult>(result);
        }

    



        [Fact]
        public void Edit_Passes_Review_To_View()
        {
            var expectedReview = new Review();
            reviewRepo.GetById(5).Returns(expectedReview);

            var result = underTest.Edit(5);

            Assert.Equal(expectedReview, result.Model);
        }

    }
}

