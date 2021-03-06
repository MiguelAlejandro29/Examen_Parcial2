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
    public class BAProdcutos
    {

        readonly string cadena = "Server=127.0.0.1; Port=3306; Database=examen2; Uid=root; Pwd=queremosla12;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public DataTable ListarProductos()
        {
            DataTable listaproducto = new DataTable();

            try
            {
                string sql = "SELECT * FROM productos;"; 
                conn = new MySqlConnection(cadena); 
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                listaproducto.Load(reader);
                reader.Close();
                conn.Close();

             
            }
            catch (Exception ex)
            {
  
            }
            return listaproducto;

        }

        public bool AgregarProducto(Productos producto)
        {
            bool agregar = false;

            try
            {
                string sql = "INSERT INTO productos VALUES (@Codigo, @Descripcion, @Precio);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Codigo", producto.CodigoP);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);

                cmd.ExecuteNonQuery();
                agregar = true; 
                conn.Close();

            }
            catch (Exception ex)
            {
            }
            return agregar;


        }

        public bool ModificarProducto(Productos producto)
        {
            bool modificar = false;

            try
            {
                string sql = "UPDATE productos SET = CodigoP =@CodigoP, Descripcion= @Descripcion, Precio = @Precio, WHERE CodigoP = @CodigoP);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@CodigoP", producto.CodigoP);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);

                cmd.ExecuteNonQuery();
                modificar = true;
                conn.Close();

            }
            catch (Exception ex)
            {
            }
            return modificar;


        }

        public bool EliminarProducto(string codigoP)
        {
            bool eliminar = false;

            try
            {
                string sql = "DELETE FROM productos WHERE CodigoP = @CodigoP;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@CodigoP", codigoP);
 

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
