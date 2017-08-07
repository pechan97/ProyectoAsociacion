using Asociacion.Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asociacion.DAO
{
    public class AlquilerDAO
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        /// <summary>
        /// Método que inserta a un nuevo alquiler
        /// </summary>
        /// <param name="alquiler">Recibe un Alquiler como parámetro</param> 
        /// <returns>Retorna el id del alquiler</returns>
        public bool Insertar(Alquiler alquiler)
        {
            NpgsqlTransaction tran = null;
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    tran = con.BeginTransaction();
                    string sql = @"INSERT INTO usuario (nombre, fecha, telefono, lugar, num_mesas, 
                             num_sillas,num_manteles, num_lasos, num_cobertor, num_sobre_mantel,
                             num_sillas_verdes,num_sillas_blancas,precio)
                           VALUES  (:nombre,  :fecha,  :telefono, 
                             :lugar,  :num_mesas, :num_sillas, :num_manteles, :num_lasos,:num_cobertor,
                            :num_sobre_mantel,:num_sillas_verdes,:num_sillas_blancas,:precio) returning id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue(":nombre", alquiler.Nombre);
                    cmd.Parameters.AddWithValue(":fecha", alquiler.Fecha);
                    cmd.Parameters.AddWithValue(":telefono", alquiler.Telefono);
                    cmd.Parameters.AddWithValue(":lugar", alquiler.Lugar);
                    cmd.Parameters.AddWithValue(":num_mesas", alquiler.Mesas);
                    cmd.Parameters.AddWithValue(":num_sillas", alquiler.Sillas);
                    cmd.Parameters.AddWithValue(":num_manteles", alquiler.Manteles);
                    cmd.Parameters.AddWithValue(":num_lasos", alquiler.Lasos);
                    cmd.Parameters.AddWithValue(":num_cobertor", alquiler.Cobertores);
                    cmd.Parameters.AddWithValue(":num_sobre_mantel", alquiler.SobreMantel);
                    cmd.Parameters.AddWithValue(":num_sillas_verdes", alquiler.SillasVerdes);
                    cmd.Parameters.AddWithValue(":num_sillas_blancas", alquiler.SillasBlancas);
                    cmd.Parameters.AddWithValue(":precio", alquiler.Total);

                    alquiler.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    tran.Commit();
                    return alquiler.Id > 0;
                }
            }
            catch (Exception ex)
            {
                if (tran != null)
                {
                    tran.Rollback();
                }
                throw new Exception(ex.Message);
            }

        }
        /// <summary>
        /// Método que muestra los alquileres buscardos por el usuario
        /// </summary>
        /// <param name="consulta">Parámetro Recibe la búsqueda del usuario</param>
        /// <param name="dgv">Parámetro que recibo los datos a mostrar en la interfaz</param>
        public void Select(string consulta, DataGridView dgv)
        {
            string a= consulta.ToUpper();
            if (a == "TODO")
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"SELECT * FROM usuario";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    try
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv.DataSource = dt;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"SELECT * FROM usuario WHERE nombre = :consulta";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue(":consulta", consulta);
                    try
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv.DataSource = dt;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            
        }
        /// <summary>
        /// Método que modifica el alquiler
        /// </summary>
        /// <param name="alquiler">Recibe un Alquiler cómo parámetros</param>
        /// <returns>Retorna si el id del alquiler a modificar es mayor a 0</returns>
        public bool Modificar(Alquiler alquiler)
        {
            NpgsqlTransaction tran = null;
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    tran = con.BeginTransaction();
                    string sql = @"UPDATE usuario 
                            SET nombre= :nombre, fecha= :fecha , telefono= :telefono, lugar= :lugar, num_mesas= :num_mesas, 
                             num_sillas= :num_sillas,num_manteles= :num_manteles, num_lasos= :num_lasos, num_cobertor= :num_cobertor, num_sobre_mantel= :num_sobre_mantel,
                             num_sillas_verdes= :num_sillas_verdes,num_sillas_blancas= :num_sillas_blancas,precio= :precio
                           WHERE id= :id";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", alquiler.Id);
                    cmd.Parameters.AddWithValue("nombre", alquiler.Nombre);
                    cmd.Parameters.AddWithValue("fecha", alquiler.Fecha);
                    cmd.Parameters.AddWithValue("telefono", alquiler.Telefono);
                    cmd.Parameters.AddWithValue("lugar", alquiler.Lugar);
                    cmd.Parameters.AddWithValue("num_mesas", alquiler.Mesas);
                    cmd.Parameters.AddWithValue("num_sillas", alquiler.Sillas);
                    cmd.Parameters.AddWithValue("num_manteles", alquiler.Manteles);
                    cmd.Parameters.AddWithValue("num_lasos", alquiler.Lasos);
                    cmd.Parameters.AddWithValue("num_cobertor", alquiler.Cobertores);
                    cmd.Parameters.AddWithValue("num_sobre_mantel", alquiler.SobreMantel);
                    cmd.Parameters.AddWithValue("num_sillas_verdes", alquiler.SillasVerdes);
                    cmd.Parameters.AddWithValue("num_sillas_blancas", alquiler.SillasBlancas);
                    cmd.Parameters.AddWithValue("precio", alquiler.Total);
                    int x = cmd.ExecuteNonQuery();
                    tran.Commit();
                    return x > 0;
                }
            }
            catch (Exception ex)
            {

                if (tran != null)
                {
                    tran.Rollback();
                }
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Método que selecciona un alquiler por id y trae sus propiedades
        /// </summary>
        /// <param name="id">Parámetro que recibe el id a modificar</param>
        /// <returns>Retorna el alquiler encontrado</returns>
        public Alquiler SelectId(int id)
        {
            try
            {
                Alquiler a = new Alquiler();
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();

                    string sql = @"select 
                                * 
                               from 
                                usuario 
                               where 
                                id = :id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue(":id", id);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        a.Id = reader.GetInt32(0);
                        a.Nombre = reader.GetString(1);
                        a.Telefono = reader.GetInt32(2);
                        a.Lugar = reader.GetString(3);
                        a.Mesas = reader.GetInt32(4);
                        a.Sillas = reader.GetInt32(5);
                        a.Manteles = reader.GetInt32(6);
                        a.Lasos = reader.GetInt32(7);
                        a.Cobertores = reader.GetInt32(8);
                        a.SobreMantel = reader.GetInt32(9);
                        a.SillasVerdes = reader.GetInt32(10);
                        a.SillasBlancas = reader.GetInt32(11);
                        a.Total = reader.GetInt32(12);
                        a.Fecha = reader.GetString(13);
                    }
                }
                return a;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
