using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IAdminRepository
    {
        Task<Inventory> AddItem(Inventory item);
    }
}
