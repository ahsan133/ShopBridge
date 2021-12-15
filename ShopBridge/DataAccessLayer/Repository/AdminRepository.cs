using DataAccessLayer.Context;
using DataAccessLayer.Interface;
using Models;
using System;
using System.Collections.Generic;
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
                this.context.Add(item);
                await this.context.SaveChangesAsync();
                return item;
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
