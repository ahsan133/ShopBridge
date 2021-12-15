using BusinessLogicLayer.Interface;
using DataAccessLayer.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Manager
{
    public class AdminManager : IAdminManager
    {
        private readonly IAdminRepository repository;

        public AdminManager(IAdminRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Inventory> AddItem(Inventory item)
        {
            try
            {
                return await this.repository.AddItem(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Inventory> ModifyItem(Inventory item)
        {
            try
            {
                return await this.repository.ModifyItem(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
