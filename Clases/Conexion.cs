using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace PRAC3_ASISTENCIA.Clases
{
    internal class Conexion
    {
        private string cadenaConexion = "server=192.168.64.1;port=3307;uid=root;pwd=JoseLuis;database=control_asistencia;";
        private MySqlConnection conexion;

        private void conectar()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void desconectar()
        {
            try
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public DataSet ejecutarConsulta(string comando)
        {
            try
            {
                conectar();

                MySqlDataAdapter da = new MySqlDataAdapter(comando, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds);

                desconectar();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en consulta: " + ex.Message);
                desconectar();
                return null;
            }
        }

        public bool ejecutarComando(string comando)
        {
            try
            {
                conectar();

                MySqlCommand cmd = new MySqlCommand(comando, conexion);
                cmd.ExecuteNonQuery();

                desconectar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en comando: " + ex.Message);
                desconectar();
                return false;
            }
        }
    }
}
