﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Groza_Bogdan_Lab2.Models;

namespace Groza_Bogdan_Lab2.Data
{
    public class Groza_Bogdan_Lab2Context : DbContext
    {
        public Groza_Bogdan_Lab2Context (DbContextOptions<Groza_Bogdan_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Groza_Bogdan_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Groza_Bogdan_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Groza_Bogdan_Lab2.Models.Category> Category { get; set; }
    }
}
