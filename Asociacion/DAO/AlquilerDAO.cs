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
        /// <param name="alquiler"></param> Recibe un participante como parámetro
        /// <returns></returns>Retorna el id del alquiler
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
        public void Select(string consulta, DataGridView dgv)
        {
            string a= consulta.ToUpper();
            if (a == "TODO")
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"SELECT nombre, fecha, telefono, lugar, num_mesas, 
                             num_sillas,num_manteles, num_lasos, num_cobertor, num_sobre_mantel,
                             num_sillas_verdes,num_sillas_blancas,precio FROM usuario";

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
                    string sql = @"SELECT nombre, fecha, telefono, lugar, num_mesas, 
                             num_sillas,num_manteles, num_lasos, num_cobertor, num_sobre_mantel,
                             num_sillas_verdes,num_sillas_blancas,precio FROM usuario WHERE nombre = :consulta";

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
    }
}
