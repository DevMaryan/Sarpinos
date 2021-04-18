﻿using Microsoft.EntityFrameworkCore;
using Sarpinos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sarpinos.Repositories
{
    public class SarpinosDbContext : DbContext
    {
        public SarpinosDbContext(DbContextOptions<SarpinosDbContext> options) : base(options)
        {

        }
        public DbSet<Offer> Offers { get; set; }
    }
}