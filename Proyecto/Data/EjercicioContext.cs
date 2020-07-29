using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyecto.Models;

namespace Proyecto.Data
{
    public class EjercicioContext : DbContext
    {
        public EjercicioContext (DbContextOptions<EjercicioContext> options)
            : base(options)
        {
        }

        public DbSet<Proyecto.Models.Ejercicio> Ejercicio { get; set; }
    }
}
