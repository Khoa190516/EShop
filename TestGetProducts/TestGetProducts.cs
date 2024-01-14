using AutoFixture;
using BussinesLayer.ResponseModels.ApiResponseModel;
using BussinesLayer.Service.IServices;
using EShopAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace TestGetProducts
{
    public class TestGetProducts
    {
        [Fact]
        public void GetProducts_ReturnsOkObjectResult_WithApiResponseData()
        {
            //Arrange
            var fixture = new Fixture();
            var mock = new Mock<IProductService>();
            var controller = new ProductsController(mock.Object);
            var expected = fixture.Create<ApiResponse>();

            mock.Setup(x => x.GetProducts(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync(expected);

            //Act
            var result = controller.GetProducts(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>());

            //Assert
            Assert.NotNull(result.Result);
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var actual = Assert.IsType<ApiResponse>(okResult.Value);
            Assert.Equal(expected, actual);
        }
    }
}