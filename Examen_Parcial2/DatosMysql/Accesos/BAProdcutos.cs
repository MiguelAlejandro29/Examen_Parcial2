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

        public DataTable Listarproducto()
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

             
            }
            catch (Exception ex)
            {
  
            }
            return listaproducto;

        }



    }
}
