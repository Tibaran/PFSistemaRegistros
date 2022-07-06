using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEntities;

namespace AppDAL
{
    public class EntradaDAL
    {
        public List<Entrada> listar()
        {
            using (PFRegistrosEntities contexto = new PFRegistrosEntities())
            {
                var query = contexto.entradas.Select(p => new Entrada {
                    EntradaId = p.EntradaId,
                    FechaHora = p.FechaHora,
                    PersonaId = p.PersonaId,
                    Destino = p.Destino,
                    Motivo = p.Motivo
                });
                return query.ToList();
            }
        }
        public void crear(Entrada newEntrada)
        {
            try
            {
                using (PFRegistrosEntities contexto = new PFRegistrosEntities())
                {
                    contexto.entradas.Add(new entrada {
                        EntradaId = newEntrada.EntradaId,
                        FechaHora = newEntrada.FechaHora,
                        PersonaId = newEntrada.PersonaId,
                        Destino = newEntrada.Destino,
                        Motivo = newEntrada.Motivo
                    });
                    contexto.SaveChanges();
                }
            }
            catch
            {
                Console.WriteLine("Error en Crear entradaDAL");
            }
        }
    }
}
