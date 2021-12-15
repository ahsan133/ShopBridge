using DataAccessLayer.Context;
using DataAccessLayer.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ShopBridgeContext context;

        public AdminRepository(ShopBridgeContext context)
        {
            this.context = context;
        }

        public async Task<Inventory> AddItem(Inventory item)
        {
            try
            {
                this.context.Inventory.Add(item);
                await this.context.SaveChangesAsync();
                return item;
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Inventory> ModifyItem(Inventory item)
        {
            try
            {
                var itemExist = this.context.Inventory.Where(x => x.Id == item.Id).SingleOrDefault();
                if (itemExist != null)
                {
                    itemExist.Name = item.Name;
                    itemExist.Description = item.Description;
                    itemExist.Price = item.Price;
                    this.context.Inventory.Update(itemExist);
                    await this.context.SaveChangesAsync();
                    return item;
                }

                return null;
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
