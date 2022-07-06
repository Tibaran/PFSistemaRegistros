using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEntities
{
    public class Entrada
    {
        public int EntradaId { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public int PersonaId { get; set; }
        public string Destino { get; set; }
        public string Motivo { get; set; }
    }
}
