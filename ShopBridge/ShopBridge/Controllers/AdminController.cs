using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ShopBridge.Controllers
{
    public class AdminController : ControllerBase
    {
        private readonly IAdminManager manager;

        public AdminController(IAdminManager manager)
        {
            this.manager = manager;
        }

        [HttpPost]
        [Route("api/addItem")]
        public async Task<IActionResult> AddItem([FromBody] Inventory item)
        {
            try
            {
                var data = await this.manager.AddItem(item);
                if (data != null)
                {
                    return this.Ok(new ResponseModel<Inventory> { Status = true, Message = "Item Added Successfully", Data = data });
                }
                else
                {
                    return this.BadRequest(new { Status = false, Message = "Item not Added." });
                }
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, ex.Message });
            }
        }

        [HttpPut]
        [Route("api/modifyItem")]
        public async Task<IActionResult> ModifyItem([FromBody] Inventory item)
        {
            try
            {
                var data = await this.manager.ModifyItem(item);
                if (data != null)
                {
                    return this.Ok(new ResponseModel<Inventory> { Status = true, Message = "Item Modified Successfully", Data = data });
                }
                else
                {
                    return this.BadRequest(new { Status = false, Message = "Item not Modified." });
                }
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, ex.Message });
            }
        }

        [HttpDelete]
        [Route("api/deleteItem")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            try
            {
                bool data = await this.manager.DeleteItem(id);
                if (data)
                {
                    return this.Ok(new { Status = true, Message = "Item deleted." });
                }
                else
                {
                    return this.BadRequest(new { Status = false, Message = "Item not deleted." });
                }
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, ex.Message });
            }
        }
    }
}
