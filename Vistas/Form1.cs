namespace PRAC3_ASISTENCIA
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.frmReportes rep = new Vistas.frmReportes();
            rep.ShowDialog();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.frmCatalogo cat = new Vistas.frmCatalogo();
            cat.ShowDialog();
        }

        private void realizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.frmAsistencia asi = new Vistas.frmAsistencia();
            asi.ShowDialog();
        }
    }
}
