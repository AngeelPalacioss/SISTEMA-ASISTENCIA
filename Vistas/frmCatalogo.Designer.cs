namespace PRAC3_ASISTENCIA.Vistas
{
    partial class frmCatalogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            btnAgregar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbAluGrupos = new ComboBox();
            txtCatBuscar = new TextBox();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnAgregar);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(cbAluGrupos);
            splitContainer1.Panel1.Controls.Add(txtCatBuscar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(729, 504);
            splitContainer1.SplitterDistance = 184;
            splitContainer1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(531, 100);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 21);
            label3.Name = "label3";
            label3.Size = new Size(132, 29);
            label3.TabIndex = 4;
            label3.Text = "Alumnado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 72);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Buscar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 72);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Filtrar:";
            // 
            // cbAluGrupos
            // 
            cbAluGrupos.FormattingEnabled = true;
            cbAluGrupos.Location = new Point(329, 101);
            cbAluGrupos.Name = "cbAluGrupos";
            cbAluGrupos.Size = new Size(121, 23);
            cbAluGrupos.TabIndex = 1;
            cbAluGrupos.SelectedIndexChanged += cbAluGrupos_SelectedIndexChanged;
            // 
            // txtCatBuscar
            // 
            txtCatBuscar.Location = new Point(23, 101);
            txtCatBuscar.Name = "txtCatBuscar";
            txtCatBuscar.Size = new Size(276, 23);
            txtCatBuscar.TabIndex = 0;
            txtCatBuscar.TextChanged += txtCatBuscar_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(729, 316);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellMouseDown += dataGridView1_CellMouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // frmCatalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 504);
            Controls.Add(splitContainer1);
            Name = "frmCatalogo";
            Text = "Catalogo";
            Load += frmCatalogo_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbAluGrupos;
        private TextBox txtCatBuscar;
        private DataGridView dataGridView1;
        private Button btnAgregar;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}