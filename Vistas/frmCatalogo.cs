using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRAC3_ASISTENCIA.Vistas
{
    public partial class frmCatalogo : Form
    {
        public frmCatalogo()
        {
            InitializeComponent();
        }

        bool cargando = true;
        private void cargarAlumnos(string filtro = "", int? idGrupo = null)
        {
            try
            {
                Clases.Conexion con = new Clases.Conexion();

                string query = @"
                    SELECT a.numero_control, 
                           CONCAT(a.nombre, ' ', a.apellido_paterno) AS nombre, 
                           g.nombre AS grupo
                    FROM alumnos a
                    JOIN grupos g ON a.id_grupo = g.id_grupo
                    WHERE a.activo = 1";

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    query += $" AND (a.nombre LIKE '%{filtro}%' OR a.numero_control LIKE '%{filtro}%')";
                }

                if (idGrupo.HasValue)
                {
                    query += $" AND a.id_grupo = {idGrupo.Value}";
                }

                query += " ORDER BY a.nombre;";

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

        private void cargarGrupos()
        {
            Clases.Conexion con = new Clases.Conexion();

            var ds = con.ejecutarConsulta("SELECT * FROM grupos");

            cbAluGrupos.DataSource = ds.Tables[0];
            cbAluGrupos.DisplayMember = "nombre";
            cbAluGrupos.ValueMember = "id_grupo";
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAlumno alumno = new frmAlumno();
            alumno.ShowDialog();
            cargarAlumnos();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            cargando = true;
            cargarGrupos();
            cbAluGrupos.SelectedIndex = -1;
            cargarAlumnos();
            cargando = false;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
        }

        private void txtCatBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            string texto = txtCatBuscar.Text.Trim();

            int? grupo = null;

            if (cbAluGrupos.SelectedValue != null && cbAluGrupos.SelectedValue.GetType() != typeof(System.Data.DataRowView))
            {
                grupo = Convert.ToInt32(cbAluGrupos.SelectedValue);
            }

            cargarAlumnos(texto, grupo);
        }

        private void cbAluGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            int? grupo = null;

            if (cbAluGrupos.SelectedValue != null && cbAluGrupos.SelectedValue.GetType() != typeof(System.Data.DataRowView))
            {
                grupo = Convert.ToInt32(cbAluGrupos.SelectedValue);
            }

            string texto = txtCatBuscar.Text.Trim();

            cargarAlumnos(texto, grupo);
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var fila = dataGridView1.SelectedRows[0];

            string numeroControl = fila.Cells["numero_control"].Value.ToString();

            var confirm = MessageBox.Show("¿Eliminar alumno?", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.No) return;

            Clases.Conexion con = new Clases.Conexion();

            string query = $@"
                UPDATE alumnos 
                SET activo = 0 
                WHERE numero_control = '{numeroControl}';";

            if (con.ejecutarComando(query))
            {
                MessageBox.Show("Alumno eliminado");
                cargarAlumnos();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dataGridView1.Rows[e.RowIndex];

            string control = fila.Cells["numero_control"].Value?.ToString() ?? "";
            string nombreCompleto = fila.Cells["nombre"].Value?.ToString() ?? "";

            string nombre = "";
            string paterno = "";

            if (!string.IsNullOrWhiteSpace(nombreCompleto))
            {
                string[] partes = nombreCompleto.Split(' ');

                nombre = partes.Length > 0 ? partes[0] : "";
                paterno = partes.Length > 1 ? partes[1] : "";
            }

            frmAlumno frm = new frmAlumno();

            frm.txtControl.Text = control;
            frm.txtNombre.Text = nombre;
            frm.txtPaterno.Text = paterno;
            

            frm.esEdicion = true;

            frm.ShowDialog();

            cargarAlumnos();
        }
    }
}
