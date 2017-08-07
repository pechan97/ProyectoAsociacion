using Asociacion.Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asociacion.DAO
{
    public class ReciboDAO
    {
        /// <summary>
        /// Método que inserta a un nuevo recibo
        /// </summary>
        /// <param name="recibo"></param> Recibe un recibo como parámetro
        /// <returns></returns>Retorna el id del recibo
        public bool Insertar(Recibo recibo)
        {
            NpgsqlTransaction tran = null;
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    tran = con.BeginTransaction();
                    string sql = @"INSERT INTO recibos (fecha, se_recibe_de, monto, descripcion)
                           VALUES  (:fecha, :se_recibe_de, :monto, :descripcion) returning id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue(":fecha", recibo.Fecha);
                    cmd.Parameters.AddWithValue(":se_recibe_de", recibo.De);
                    cmd.Parameters.AddWithValue(":monto", recibo.Monto);
                    cmd.Parameters.AddWithValue(":descripcion", recibo.Descripcion);

                    recibo.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    tran.Commit();
                    return recibo.Id > 0;
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
            string a = consulta.ToUpper();
            if (a == "TODO")
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    string sql = @"SELECT * FROM recibos";

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
                    string sql = @"SELECT * FROM recibos WHERE se_recibe_de = :consulta";

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
        public bool Modificar(Recibo recibo)
        {
            NpgsqlTransaction tran = null;
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();
                    tran = con.BeginTransaction();
                    string sql = @"UPDATE recibos 
                            SET fecha= :fecha, se_recibe_de= :se_recibe_de, monto= :monto, descripcion= :descripcion
                           WHERE id= :id";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("fecha", recibo.Fecha);
                    cmd.Parameters.AddWithValue("se_recibe_de", recibo.De);
                    cmd.Parameters.AddWithValue("monto", recibo.Monto);
                    cmd.Parameters.AddWithValue("descripcion", recibo.Descripcion);
                    cmd.Parameters.AddWithValue("id", recibo.Id);
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
        public Recibo SelectId(int id)
        {
            try
            {
                Recibo r = new Recibo();
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
                {
                    con.Open();

                    string sql = @"select 
                                * 
                               from 
                                recibos 
                               where 
                                id = :id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue(":id", id);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        r.Id = reader.GetInt32(0);
                        r.Fecha = reader.GetString(1);
                        r.Descripcion = reader.GetString(2);
                        r.Monto = reader.GetInt32(3);
                        r.De = reader.GetString(4);
                    }
                }
                return r;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
