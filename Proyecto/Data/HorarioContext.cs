using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyecto.Models;

namespace Proyecto.Data
{
    public class HorarioContext : DbContext
    {
        public HorarioContext (DbContextOptions<HorarioContext> options)
            : base(options)
        {
        }

        public DbSet<Proyecto.Models.Horario> Horario { get; set; }
    }
}
