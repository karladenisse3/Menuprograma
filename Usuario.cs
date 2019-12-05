using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using menu1.Interfacez;
namespace menu1.Clases
{
    public abstract class Usuario
    {

        private string nombreusuario;

        public string NombreUsuario
        {
            get { return nombreusuario; }
            set { nombreusuario = value; }
        }

        private string contrasena;

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

       
    }
}
