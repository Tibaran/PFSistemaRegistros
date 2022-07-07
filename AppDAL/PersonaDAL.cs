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
                    if(result.First() == null)
                    {
                        return null;
                    }
                    return result.First();
                }
            }
            catch
            {
                Console.WriteLine("Error en BuscarPorDni personaDAL");
                return null;
            }
        }
        public CPersona buscarPorId(int id)
        {
            try
            {
                using (PFRegistrosEntities contexto = new PFRegistrosEntities())
                {
                    var personas = contexto.personas;
                    var result = from p in personas
                                 where p.PersonaId == id
                                 select new CPersona {
                                     PersonaId = p.PersonaId,
                                     Nombre = p.Nombre,
                                     Apellido = p.Apellido,
                                     DNI = p.Dni,
                                     Edad = (int)p.Edad,
                                     Sexo = p.Sexo
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
                Console.WriteLine("Error en BuscarPorId personaDAL");
                return null;
            }
        }
        public string editar(CPersona editarPersona)
        {
            
            try
            {
                using (PFRegistrosEntities contexto = new PFRegistrosEntities())
                {
                    
                    var resultado = contexto.personas.Find(editarPersona.PersonaId);
                    if (resultado != null)
                    {
                        resultado.Nombre = editarPersona.Nombre;
                        resultado.Apellido = editarPersona.Apellido;
                        resultado.Dni = editarPersona.DNI;
                        resultado.Edad = editarPersona.Edad;
                        resultado.Sexo = editarPersona.Sexo;

                        contexto.SaveChanges();
                        return "Se edito con exito!";
                    }
                    else
                    {
                        return "La persona no existe!";
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error en BuscarPorId personaDAL");
                return "Error al intentar eliminar persona!";
            }
        }

        public string eliminar(int id)
        {
            try
            {
                using (PFRegistrosEntities contexto = new PFRegistrosEntities())
                {
                    var resultado = (from p in contexto.personas
                                     where p.PersonaId == id
                                     select p).FirstOrDefault();
                    if(resultado != null)
                    {
                        contexto.personas.Remove(resultado);
                        contexto.SaveChanges();
                        return "Se elimino con exito!";
                    }
                    else
                    {
                        return "La persona no existe!";
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error en Eliminar personaDAL");
                return "Error al intentar eliminar persona!";
            }
        }
    }
}
