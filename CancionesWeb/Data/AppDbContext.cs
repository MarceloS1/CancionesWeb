using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CancionesWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CancionesWeb.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Canciones> Cancion { get; set; }
    }
}
