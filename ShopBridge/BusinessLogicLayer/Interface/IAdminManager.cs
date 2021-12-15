using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IAdminManager
    {
        Task<Inventory> AddItem(Inventory item);

        Task<Inventory> ModifyItem(Inventory item);

        Task<bool> DeleteItem(int id);

        Task<IEnumerable<Inventory>> GetItems();
    }
}
