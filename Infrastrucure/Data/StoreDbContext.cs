﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {

        }

        public DbSet<Product>? Products { get; set; }
        public DbSet<ProductBrand>? ProductBrands { get; set; }
        public DbSet<ProductType>? ProductType { get; set; }


        class MyClass
        {

        }
    }
}
