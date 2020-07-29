using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Horario
    {
        public int Id { get; set; }
        public int Hora_inicio { get; set; }
        public int Hora_final { get; set; }
        public int Dia { get; set; }
    }
}
