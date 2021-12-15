using BusinessLogicLayer.Interface;
using Models;
using Moq;
using ShopBridge.Controllers;
using System;
using Xunit;

namespace ShopBridgeTesting
{
    public class Test
    {
        [Fact]
        public void WhenItemAdded_ShouldAdditem()
        {
            var services = new Mock<IAdminManager>();
            var controller = new AdminController(services.Object);
            var input = new Inventory()
            {
                Name = "ahsan",
                Description = "asdszx",
                Price = 11
            };
            var data = controller.AddItem(input);
            Assert.NotNull(data);
        }

        [Fact]
        public void WhenItemModified_ShouldModifyitem()
        {
            var services = new Mock<IAdminManager>();
            var controller = new AdminController(services.Object);
            var input = new Inventory()
            {
                Id = 1,
                Name = "ahsan",
                Description = "asdszx",
                Price = 11
            };
            var data = controller.ModifyItem(input);
            Assert.NotNull(data);
        }
    }
}
