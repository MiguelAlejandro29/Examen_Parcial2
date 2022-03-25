using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosMysql.Entidades
{
    public class Usuarios
    {
        public string Codigo { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }

        public Usuarios()
        {
        }

        public Usuarios(string codigo, string clave, string nombre)
        {
            Codigo = codigo;
            Clave = clave;
            Nombre = nombre;
        }
    }


}
