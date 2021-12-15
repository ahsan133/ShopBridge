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
        public void Test1()
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
    }
}
