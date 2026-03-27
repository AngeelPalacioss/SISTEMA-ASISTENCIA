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
    public partial class frmAsistencia : Form
    {
        public frmAsistencia()
        {
            InitializeComponent();
        }
        private void cargarGrupos()
        {
            Clases.Conexion con = new Clases.Conexion();

            var ds = con.ejecutarConsulta("SELECT * FROM grupos");

            cbGrupos.DataSource = ds.Tables[0];
            cbGrupos.DisplayMember = "nombre";
            cbGrupos.ValueMember = "id_grupo";
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            cargarGrupos();
            cbGrupos.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
        }

        private void cbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbGrupos.SelectedValue == null || cbGrupos.SelectedValue is System.Data.DataRowView)
                    return;

                int idGrupo = Convert.ToInt32(cbGrupos.SelectedValue);

                Clases.Conexion con = new Clases.Conexion();

                string query = $@"
            SELECT id_alumno, numero_control, nombre
            FROM alumnos
            WHERE id_grupo = {idGrupo} AND activo = 1;";

                var ds = con.ejecutarConsulta(query);

                if (ds == null) return;

                dataGridView1.DataSource = ds.Tables[0];

                if (!dataGridView1.Columns.Contains("Asistencia"))
                {
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                    chk.Name = "Asistencia";
                    chk.HeaderText = "✔";
                    dataGridView1.Columns.Add(chk);
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;
                    row.Cells["Asistencia"].Value = false;
                }

                string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

                string querySesion = $@"
            SELECT id_sesion 
            FROM sesiones 
            WHERE id_grupo = {idGrupo} AND fecha = '{fecha}';";

                var dsSesion = con.ejecutarConsulta(querySesion);

                if (dsSesion == null || dsSesion.Tables[0].Rows.Count == 0)
                    return;

                int idSesion = Convert.ToInt32(dsSesion.Tables[0].Rows[0]["id_sesion"]);

                string queryAsistencia = $@"
            SELECT id_alumno, estado
            FROM asistencias
            WHERE id_sesion = {idSesion};";

                var dsAsistencia = con.ejecutarConsulta(queryAsistencia);

                if (dsAsistencia == null) return;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    int idAlumno = Convert.ToInt32(row.Cells["id_alumno"].Value);

                    foreach (DataRow dr in dsAsistencia.Tables[0].Rows)
                    {
                        if (Convert.ToInt32(dr["id_alumno"]) == idAlumno)
                        {
                            row.Cells["Asistencia"].Value = Convert.ToBoolean(dr["estado"]);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbGrupos.SelectedValue == null || cbGrupos.SelectedValue is System.Data.DataRowView)
                {
                    MessageBox.Show("Seleccione un grupo válido");
                    return;
                }

                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No hay alumnos para registrar.");
                    return;
                }

                Clases.Conexion con = new Clases.Conexion();

                int idGrupo = Convert.ToInt32(cbGrupos.SelectedValue);
                int idSesion = 0;

                string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

                string querySesion = $@"
            SELECT id_sesion 
            FROM sesiones 
            WHERE id_grupo = {idGrupo} AND fecha = '{fecha}';";

                var dsSesion = con.ejecutarConsulta(querySesion);

                if (dsSesion != null && dsSesion.Tables[0].Rows.Count > 0)
                {
                    idSesion = Convert.ToInt32(dsSesion.Tables[0].Rows[0]["id_sesion"]);
                }
                else
                {
                    string insertSesion = $@"
                INSERT INTO sesiones (id_grupo, fecha) 
                VALUES ({idGrupo}, '{fecha}');";

                    con.ejecutarComando(insertSesion);

                    var dsNueva = con.ejecutarConsulta(querySesion);
                    idSesion = Convert.ToInt32(dsNueva.Tables[0].Rows[0]["id_sesion"]);
                }

                string deleteQuery = $@"DELETE FROM asistencias WHERE id_sesion = {idSesion};";
                con.ejecutarComando(deleteQuery);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    int idAlumno = Convert.ToInt32(row.Cells["id_alumno"].Value);

                    bool estado = false;
                    if (row.Cells["Asistencia"].Value != null)
                    {
                        estado = Convert.ToBoolean(row.Cells["Asistencia"].Value);
                    }

                    string insert = $@"
                INSERT INTO asistencias (id_sesion, id_alumno, estado)
                VALUES ({idSesion}, {idAlumno}, {(estado ? 1 : 0)});";

                    con.ejecutarComando(insert);
                }

                MessageBox.Show("Asistencia guardada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                row.Cells["Asistencia"].Value = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                row.Cells["Asistencia"].Value = false;

            }
        }

        private void txtBuscarAlu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarAlu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string control = txtBuscarAlu.Text.Trim();

                if (string.IsNullOrWhiteSpace(control)) return;

                bool encontrado = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    string numero = row.Cells["numero_control"].Value?.ToString();

                    if (numero == control)
                    {
                        row.Cells["Asistencia"].Value = true;

                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;

                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show("Alumno no encontrado");
                }

                txtBuscarAlu.Clear();
            }

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            cbGrupos_SelectedIndexChanged(null, null);
        }
    }
}
