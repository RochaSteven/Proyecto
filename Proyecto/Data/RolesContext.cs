using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyecto.Models;

namespace Proyecto.Data
{
    public class RolesContext : DbContext
    {
        public RolesContext (DbContextOptions<RolesContext> options)
            : base(options)
        {
        }

        public DbSet<Proyecto.Models.Rol> Rol { get; set; }
    }
}
