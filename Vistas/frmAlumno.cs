using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PRAC3_ASISTENCIA.Vistas
{
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        public bool esEdicion = false;

        private void cargarGrupos()
        {
            Clases.Conexion con = new Clases.Conexion();

            var ds = con.ejecutarConsulta("SELECT * FROM grupos");

            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "id_grupo";
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            cargarGrupos();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtControl.Text))
                {
                    MessageBox.Show("Ingrese número de control");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Ingrese nombre");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPaterno.Text))
                {
                    MessageBox.Show("Ingrese apellido paterno");
                    return;
                }

                if (comboBox1.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un grupo");
                    return;
                }

                Clases.Conexion con = new Clases.Conexion();

                string check = $@"SELECT * FROM alumnos WHERE numero_control = '{txtControl.Text}';";

                var ds = con.ejecutarConsulta(check);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("El número de control ya existe");
                    return;
                }

                string query = $@" INSERT INTO alumnos (numero_control, nombre, apellido_paterno, apellido_materno, id_grupo, activo) VALUES ('{txtControl.Text}', '{txtNombre.Text}', '{txtPaterno.Text}', '{txtMaterno.Text}', {comboBox1.SelectedValue}, 1);";

                if (con.ejecutarComando(query))
                {
                    MessageBox.Show("Alumno agregado correctamente ");
                    this.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
