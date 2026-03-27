namespace PRAC3_ASISTENCIA.Vistas
{
    partial class frmAsistencia
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
            splitContainer1 = new SplitContainer();
            dtpFecha = new DateTimePicker();
            label4 = new Label();
            btnTodos = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            label3 = new Label();
            txtBuscarAlu = new TextBox();
            label2 = new Label();
            cbGrupos = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(dtpFecha);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(btnTodos);
            splitContainer1.Panel1.Controls.Add(btnLimpiar);
            splitContainer1.Panel1.Controls.Add(btnGuardar);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(txtBuscarAlu);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(cbGrupos);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 153;
            splitContainer1.TabIndex = 0;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(12, 118);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(221, 23);
            dtpFecha.TabIndex = 10;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 30);
            label4.Name = "label4";
            label4.Size = new Size(275, 29);
            label4.TabIndex = 9;
            label4.Text = "Registro de Asistencia";
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(667, 30);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(106, 23);
            btnTodos.TabIndex = 8;
            btnTodos.Text = "Marcar Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(632, 59);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(63, 23);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(532, 30);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar Asistencia";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 93);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Buscar:";
            // 
            // txtBuscarAlu
            // 
            txtBuscarAlu.Location = new Point(292, 118);
            txtBuscarAlu.Name = "txtBuscarAlu";
            txtBuscarAlu.Size = new Size(249, 23);
            txtBuscarAlu.TabIndex = 4;
            txtBuscarAlu.TextChanged += txtBuscarAlu_TextChanged;
            txtBuscarAlu.KeyDown += txtBuscarAlu_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(589, 93);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Grupo:";
            // 
            // cbGrupos
            // 
            cbGrupos.FormattingEnabled = true;
            cbGrupos.Items.AddRange(new object[] { "A", "B", "C" });
            cbGrupos.Location = new Point(589, 118);
            cbGrupos.Name = "cbGrupos";
            cbGrupos.Size = new Size(125, 23);
            cbGrupos.TabIndex = 2;
            cbGrupos.SelectedIndexChanged += cbGrupos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 93);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Fecha:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 293);
            dataGridView1.TabIndex = 0;
            // 
            // frmAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "frmAsistencia";
            Text = "frmAsistencia";
            Load += frmAsistencia_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label3;
        private TextBox txtBuscarAlu;
        private Label label2;
        private ComboBox cbGrupos;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnTodos;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Label label4;
        private DateTimePicker dtpFecha;
    }
}