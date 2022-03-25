using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosMysql.Entidades;

namespace DatosMysql.Accesos
{
    public class BaseDatos
    {

        readonly string cadena = "Server:127.0.0.1; Port=3306; Database=examen2; Uid=root; Pwd=queremosla12;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public Usuarios Login(string codigo, string clave)
        {
            Usuarios user = null;

            try
            {
                string sql = "SELECT * FROM usuario WHERE Codigo = @Codigo AND Clave = @Clave;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Clave", clave);

                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    user = new Usuarios();
                    user.Codigo = reader[0].ToString();
                    user.Clave = reader[1].ToString();
                    user.Nombre = reader[2].ToString();
                }

            }
            catch (Exception ex)
            {

                
            }
            return user;

        }


    }
}
