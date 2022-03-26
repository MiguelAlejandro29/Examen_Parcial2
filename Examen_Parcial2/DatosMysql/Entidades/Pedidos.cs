using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosMysql.Entidades
{
    public class Pedidos
    {
        public int Id { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public Pedidos()
        {
        }

        public Pedidos(int id, string nombre_Cliente, string producto, decimal precio, int cantidad)
        {
            Id = id;
            Nombre_Cliente = nombre_Cliente;
            Producto = producto;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}
