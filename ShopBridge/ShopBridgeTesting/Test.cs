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
        public void WhenItemAdded_ShouldAddItem()
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
        public void WhenItemModified_ShouldModifyItem()
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

        [Fact]
        public void WhenItemDeleted_ShouldDeleteItem()
        {
            var services = new Mock<IAdminManager>();
            var controller = new AdminController(services.Object);
            var data = controller.DeleteItem(2);
            Assert.NotNull(data);
        }

        [Fact]
        public void WhenItemsRetreived_ShouldRetreiveItem()
        {
            var services = new Mock<IAdminManager>();
            var controller = new AdminController(services.Object);
            var data = controller.GetItems();
            Assert.NotNull(data);
        }
    }
}
