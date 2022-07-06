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
                    Fecha = p.Fecha,
                    Hora = (TimeSpan)p.Hora,
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
                        Fecha = newEntrada.Fecha,
                        Hora = newEntrada.Hora,
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
        public Entrada buscarPorId(int id)
        {
            try
            {
                using (PFRegistrosEntities contexto = new PFRegistrosEntities())
                {
                    var entradas = contexto.entradas;
                    var result = from p in entradas
                                where p.EntradaId == id
                                select new Entrada {
                                    EntradaId = p.EntradaId,
                                    Fecha = p.Fecha,
                                    Hora = (TimeSpan)p.Hora,
                                    PersonaId = p.PersonaId,
                                    Destino = p.Destino,
                                    Motivo = p.Motivo
                                };
                    if (result.First() == null)
                    {
                        return null;
                    }
                    return result.First();
                }
            }
            catch
            {
                Console.WriteLine("Error en BuscarPorId entradaDAL");
                return null;
            }
        }

        public List<Entrada> filtrarPorFecha(DateTime fecha)
        {
            try
            {
                using (PFRegistrosEntities contexto = new PFRegistrosEntities())
                {
                    var entradas = contexto.entradas;
                    var query = from p in entradas
                                where p.Fecha == fecha
                                select new Entrada {
                        EntradaId = p.EntradaId,
                        Fecha = p.Fecha,
                        Hora = (TimeSpan)p.Hora,
                        PersonaId = p.PersonaId,
                        Destino = p.Destino,
                        Motivo = p.Motivo
                    };
                    return query.ToList();
                }
            }
            catch
            {
                Console.WriteLine("Error en Crear entradaDAL");
                return new List<Entrada>();
            }
        }
    }
}
