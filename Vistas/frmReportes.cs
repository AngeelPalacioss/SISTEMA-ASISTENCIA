using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PRAC3_ASISTENCIA.Vistas
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void cargarGrupos()
        {
            Clases.Conexion con = new Clases.Conexion();

            var ds = con.ejecutarConsulta("SELECT * FROM grupos");

            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "id_grupo";
        }

        private void cargarHistorial()
        {
            Clases.Conexion con = new Clases.Conexion();

            string query = @"
                SELECT 
                    CONCAT(a.nombre, ' ', a.apellido_paterno) AS alumno,
                    g.nombre AS grupo,
                    s.fecha,
                    CASE 
                        WHEN asi.estado = 1 THEN 'Presente'
                        ELSE 'Falta'
                    END AS estado
                FROM asistencias asi
                JOIN alumnos a ON asi.id_alumno = a.id_alumno
                JOIN sesiones s ON asi.id_sesion = s.id_sesion
                JOIN grupos g ON s.id_grupo = g.id_grupo
                ORDER BY s.fecha DESC;";

            var ds = con.ejecutarConsulta(query);

            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }



        private void frmReportes_Load(object sender, EventArgs e)
        {
            cargarGrupos();
            comboBox1.SelectedIndex = -1;
            cargarHistorial();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (comboBox1.SelectedValue == null || comboBox1.SelectedValue is System.Data.DataRowView)
                    return;

                int idGrupo = Convert.ToInt32(comboBox1.SelectedValue);

                Clases.Conexion con = new Clases.Conexion();

                string query = $@"
                        SELECT 
                            CONCAT(a.nombre, ' ', a.apellido_paterno) AS alumno,
                            g.nombre AS grupo,
                            s.fecha,
                            CASE 
                                WHEN asi.estado = 1 THEN 'Presente'
                                ELSE 'Falta'
                            END AS estado
                        FROM asistencias asi
                        JOIN alumnos a ON asi.id_alumno = a.id_alumno
                        JOIN sesiones s ON asi.id_sesion = s.id_sesion
                        JOIN grupos g ON s.id_grupo = g.id_grupo
                        WHERE g.id_grupo = {idGrupo}
                        ORDER BY s.fecha DESC;";

                var ds = con.ejecutarConsulta(query);

                if (ds != null)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void txtBuscarAlu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Clases.Conexion con = new Clases.Conexion();

                string texto = txtBuscarAlu.Text.Trim();

                string query = $@"
                    SELECT 
                        CONCAT(a.nombre, ' ', a.apellido_paterno) AS alumno,
                        g.nombre AS grupo,
                        s.fecha,
                        CASE 
                            WHEN asi.estado = 1 THEN 'Presente'
                            ELSE 'Falta'
                        END AS estado
                    FROM asistencias asi
                    JOIN alumnos a ON asi.id_alumno = a.id_alumno
                    JOIN sesiones s ON asi.id_sesion = s.id_sesion
                    JOIN grupos g ON s.id_grupo = g.id_grupo
                    WHERE a.nombre LIKE '%{texto}%'
                    ORDER BY s.fecha DESC;";

                var ds = con.ejecutarConsulta(query);

                if (ds != null)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarAlu.Text = "";
            comboBox1.SelectedIndex = -1;

            cargarHistorial();
        }
    }
}
