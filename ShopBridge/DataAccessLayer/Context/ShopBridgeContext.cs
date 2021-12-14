using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Context
{
    public class ShopBridgeContext : DbContext
    {
        public ShopBridgeContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Inventory> Inventory { get; set; }
    }
}
