using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEntities;
using AppDAL;

namespace AppBLL
{
    public class CEntradaBLL
    {
        EntradaDAL entradaD = new EntradaDAL();
        public List<Entrada> ListarBLL()
        {
            return entradaD.listar();
        }

        public void CrearEntrada(Entrada nuevaEntrada)
        {
            entradaD.crear(nuevaEntrada);
        }

    }
}
