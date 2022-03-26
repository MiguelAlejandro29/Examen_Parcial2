using DatosMysql.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosMysql.Accesos
{
    public class PedidosBD
    {
        readonly string cadena = "Server=127.0.0.1; Port=3306; Database=examen2; Uid=root; Pwd=queremosla12;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public DataTable ListaPedido()
        {
            DataTable listapedido = new DataTable();

            try
            {
                string sql = "SELECT * FROM pedidos;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                listapedido.Load(reader);
                reader.Close();
                conn.Close();


            }
            catch (Exception ex)
            {

            }
            return listapedido;

        }
        
        
        public bool InsertarPedido(Pedidos pedido)
        {
            bool inserto = false;

            try
            {
                string sql = "INSERT INTO pedidos VALUES(@Id, @Nombre_Cliente, @Producto,@Precio, @Cantidad );";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", pedido.Id);
                cmd.Parameters.AddWithValue("@Nombre_Cliente", pedido.Nombre_Cliente);
                cmd.Parameters.AddWithValue("@Producto", pedido.Producto);
                cmd.Parameters.AddWithValue("@Precio", pedido.Precio);
                cmd.Parameters.AddWithValue("@Cantidad", pedido.Cantidad);

                cmd.ExecuteNonQuery();
                inserto = true;
                conn.Close();
            }
            catch (Exception)
            {

                
            }
            return inserto;

        }

        public bool ModificarPedido(Pedidos pedido)
        {
            bool modificar = false;

            try
            {
                string sql = "UPDATE pedidos SET Nombre_Cliente = @Nombre_Cliente, Producto = @Producto, Precio = @Precio, Cantidad = @Cantidad WHERE Nombre_Cliente = @Nombre_Cliente ;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@Id", pedido.Id);
                cmd.Parameters.AddWithValue("@Nombre_Cliente", pedido.Nombre_Cliente);
                cmd.Parameters.AddWithValue("@Producto", pedido.Producto);
                cmd.Parameters.AddWithValue("@Precio", pedido.Precio);
                cmd.Parameters.AddWithValue("@Cantidad", pedido.Cantidad);

                cmd.ExecuteNonQuery();
                modificar = true;
                conn.Close();

            }
            catch (Exception ex)
            {
            }
            return modificar;


        }

        public bool EliminarPedido(string codigo)
        {
            bool eliminar = false;

            try
            {
                string sql = "DELETE FROM pedidos WHERE Nombre_Cliente = @Nombre_Cliente;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Nombre_Cliente", codigo);


                cmd.ExecuteNonQuery();
                eliminar = true;
                conn.Close();

            }
            catch (Exception ex)
            {
            }
            return eliminar;


        }



    }
}
