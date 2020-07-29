using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyecto.Models;

namespace Proyecto.Data
{
    public class RutinaContext : DbContext
    {
        public RutinaContext (DbContextOptions<RutinaContext> options)
            : base(options)
        {
        }

        public DbSet<Proyecto.Models.Rutina> Rutina { get; set; }
    }
}
