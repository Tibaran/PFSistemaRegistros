using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEntities;
using AppDAL;

namespace AppBLL
{
    public class CUsuarioBLL
    {
        UsuarioDAL usuarioDAL = new UsuarioDAL();

        public List<Usuario> ListarBLL()
        {
            return usuarioDAL.listar();
        }
        public void Crear(Usuario user)
        {
            usuarioDAL.crear(user);
        }

        public string Editar(Usuario editar)
        {
            return usuarioDAL.editar(editar);
        }

        public string Eliminar(int id)
        {
            return usuarioDAL.eliminar(id);
        }
        public Usuario BuscarPorId(int id)
        {
            return usuarioDAL.buscarPorId(id);
        }
        public Usuario BuscarPorUsernameAndPassword(string user, string pass)
        {
            return usuarioDAL.buscarPorUsernameAndPassword(user, pass);
        }
        public Usuario BuscarPorUsername(string user)
        {
            return usuarioDAL.buscarPorUsername(user);
        }
    }
}
