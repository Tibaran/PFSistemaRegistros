using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEntities;
using AppDAL;

namespace AppBLL
{
    public class CPersonaBLL
    {
        PersonaDAL personaDAL = new PersonaDAL();
        public List<CPersona> ListarBLL()
        {
            return personaDAL.listar();
        }

        public CPersona BuscarPorDni(string dni)
        {
            return personaDAL.buscarPorDni(dni);
        }
        public CPersona BuscarPorId(int id)
        {
            return personaDAL.buscarPorId(id);
        }

        public void Crear(CPersona persona)
        {
            personaDAL.crear(persona);
        }

        public string Editar(CPersona editar)
        {
            return personaDAL.editar(editar);
        }

        public string Eliminar(int id)
        {
            return personaDAL.eliminar(id);
        }
    }
}
