using Asociacion.Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociacion.DAO
{
    public class IngresoDAO
    {
        /// <summary>
        /// Método que autentifica si el usuario existe y la contraseña 
        /// </summary>
        /// <param name="ingreso">Recibe un ingreso como parámetro</param> 
        /// <returns>Retorna la persona ingresada o un nulo si no existe</returns> 
        public Ingreso Autentificar(Ingreso ingreso)
        {
            try
            {
                Ingreso i = new Ingreso();
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"SELECT id, usuario, password FROM ingresar WHERE usuario = :usu and password = :con";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue(":usu", ingreso.Usuario);
                    cmd.Parameters.AddWithValue(":con", ingreso.Password);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        i.Id = reader.GetInt32(0);
                        i.Usuario = reader.GetString(1);
                        i.Password = reader.GetString(2);
                    }
                }
                return i;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
