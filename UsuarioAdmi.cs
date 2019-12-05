using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using menu1.Interfacez;
namespace menu1.Clases
{
    public class UsuarioAdmi : Usuario, InterfazGeneral

    {
        public string Consultar()
        {
            return "Esto es una Consulta";
        }

        public string Eliminar()
        {
            return "Esto es una Eliminación";
        }

        public string Inprimir()
        {
            return "Esto es una Impresión";
        }

        public string Insertar()
        {
            return "Esto es un Ingreso";
        }

        public string Modificar()
        {
            return "Esto es una Modificación";
        }

        public string Procesar()
        {
            return "Esto es un Proceso";
        }
    }
}
