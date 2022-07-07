using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEntities;

namespace AppDAL
{
    public class UsuarioDAL
    {
        public List<Usuario> listar()
        {
            using (PFRegistrosEntities contexto = new PFRegistrosEntities())
            {
                var query = contexto.usuarios.Select(p => new Usuario {
                    UsuarioId = p.UsuarioId,
                    Username = p.Username,
                    Password = p.Password,
                });
                return query.ToList();
            }
        }
        public void crear(Usuario newUsuario)
        {
            try
            {
                using (PFRegistrosEntities contexto = new PFRegistrosEntities())
                {
                    contexto.usuarios.Add(new usuario {
                        UsuarioId = newUsuario.UsuarioId,
                        Username = newUsuario.Username,
                        Password = newUsuario.Password,
                    });
                    contexto.SaveChanges();

                }
            }
            catch
            {
                Console.WriteLine("Error en Crear usuarioDAL");
            }
        }
        public string editar(Usuario editarUsuario)
        {

            try
            {
                using (PFRegistrosEntities contexto = new PFRegistrosEntities())
                {

                    var resultado = contexto.usuarios.Find(editarUsuario.UsuarioId);
                    if (resultado != null)
                    {
                        resultado.Username = editarUsuario.Username;
                        resultado.Password = editarUsuario.Password;

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
                Console.WriteLine("Error en editar usuarioDAL");
                return "Error al intentar editar usuario!";
            }
        }
        public string eliminar(int id)
        {
            try
            {
                using (PFRegistrosEntities contexto = new PFRegistrosEntities())
                {
                    var resultado = (from p in contexto.usuarios
                                     where p.UsuarioId == id
                                     select p).FirstOrDefault();
                    if (resultado != null)
                    {
                        contexto.usuarios.Remove(resultado);
                        contexto.SaveChanges();
                        return "Se elimino con exito!";
                    }
                    else
                    {
                        return "El usuario no existe!";
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error en Eliminar usuarioDAL");
                return "Error al intentar eliminar usuario!";
            }
        }
        public Usuario buscarPorId(int id)
        {
            try
            {
                using (PFRegistrosEntities contexto = new PFRegistrosEntities())
                {
                    var usuarios = contexto.usuarios;
                    var result = from p in usuarios
                                 where p.UsuarioId == id
                                 select new Usuario {
                                     UsuarioId = p.UsuarioId,
                                     Username = p.Username,
                                     Password = p.Password,
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
                Console.WriteLine("Error en BuscarPorId usuarioDAL");
                return null;
            }
        }
        public Usuario buscarPorUsernameAndPassword(string user, string pass)
        {
            try
            {
                using (PFRegistrosEntities contexto = new PFRegistrosEntities())
                {
                    var usuarios = contexto.usuarios;
                    var result = from p in usuarios
                                 where p.Username == user && p.Password == pass
                                 select new Usuario {
                                     UsuarioId = p.UsuarioId,
                                     Username = p.Username,
                                     Password = p.Password,
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
                Console.WriteLine("Error en BuscarPorUsernamePassword usuarioDAL");
                return null;
            }
        }
        public Usuario buscarPorUsername(string user)
        {
            try
            {
                using (PFRegistrosEntities contexto = new PFRegistrosEntities())
                {
                    var usuarios = contexto.usuarios;
                    var result = from p in usuarios
                                 where p.Username == user
                                 select new Usuario {
                                     UsuarioId = p.UsuarioId,
                                     Username = p.Username,
                                     Password = p.Password,
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
                Console.WriteLine("Error en BuscarPorUsername usuarioDAL");
                return null;
            }
        }
    }
}
