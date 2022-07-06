using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEntities;

namespace AppDAL
{
    public class PersonaDAL
    {
        public List<CPersona> listar()
        {
            using (PFRegistrosEntities contexto = new PFRegistrosEntities())
            {
                var query = contexto.personas.Select(p => new CPersona {
                    PersonaId = p.PersonaId,
                    Nombre = p.Nombre,
                    Apellido = p.Apellido,
                    DNI = p.Dni,
                    Edad = (int)p.Edad,
                    Sexo = p.Sexo
                });
                return query.ToList();
            }
        }

        public void crear(CPersona newPersona)
        {
            try
            {
                using (PFRegistrosEntities contexto = new PFRegistrosEntities())
                {
                    contexto.personas.Add(new persona {
                        PersonaId = newPersona.PersonaId,
                        Nombre = newPersona.Nombre,
                        Apellido = newPersona.Apellido,
                        Dni = newPersona.DNI,
                        Edad = newPersona.Edad,
                        Sexo = newPersona.Sexo
                    });
                    contexto.SaveChanges();
                    
                }
            }
            catch
            {
                Console.WriteLine("Error en Crear personaDAL");
            }
        }

        public CPersona buscarPorDni(string dni)
        {
            try
            {
                using (PFRegistrosEntities contexto = new PFRegistrosEntities())
                {
                    var personas = contexto.personas;
                    var result = from p in personas
                                where p.Dni == dni
                                select new CPersona {
                                    PersonaId = p.PersonaId,
                                    Nombre = p.Nombre,
                                    Apellido = p.Apellido,
                                    DNI = p.Dni,
                                    Edad = (int)p.Edad,
                                    Sexo = p.Sexo
                                };
                    return result.First();
                }
            }
            catch
            {
                Console.WriteLine("Error en BuscarPorDni personaDAL");
                return new CPersona();
            }
        }
    }
}
