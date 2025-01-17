﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LD_EC_PiaBackEnd.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LD_EC_PiaBackEnd
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Rifa> Rifas { get; set; }
        public DbSet<Prize> Prizes { get; set; }
        public DbSet<Players> Players { get; set; } 
        public DbSet<Games> Games { get; set; }


    }
}
