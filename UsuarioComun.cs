using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using menu1.Clases;
using menu1.Interfacez;
namespace menu1.Clases
{
    public class UsuarioComun : Usuario, InterfaceProceso
    {
        public string Consultar()
        {
            return "Esto es una Consulta";
        }

        public string Inprimir()
        {
                     return "Esto es una Impresión";
        }

        public string Procesar()
        {
            return "Esto es un Proceso";
        }
    }
}
