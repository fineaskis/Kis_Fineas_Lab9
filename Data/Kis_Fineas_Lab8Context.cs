#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kis_Fineas_Lab8.Models;

namespace Kis_Fineas_Lab8.Data
{
    public class Kis_Fineas_Lab8Context : DbContext
    {
        public Kis_Fineas_Lab8Context (DbContextOptions<Kis_Fineas_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Kis_Fineas_Lab8.Models.Book> Book { get; set; }

        public DbSet<Kis_Fineas_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Kis_Fineas_Lab8.Models.Category> Category { get; set; }
    }
}
