namespace PRAC3_ASISTENCIA
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            historiaToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            cataToolStripMenuItem = new ToolStripMenuItem();
            gruposToolStripMenuItem = new ToolStripMenuItem();
            asistenciaToolStripMenuItem = new ToolStripMenuItem();
            realizarToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            lblFecha = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.PaleTurquoise;
            menuStrip1.Items.AddRange(new ToolStripItem[] { historiaToolStripMenuItem, cataToolStripMenuItem, asistenciaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(342, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // historiaToolStripMenuItem
            // 
            historiaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reportesToolStripMenuItem });
            historiaToolStripMenuItem.Name = "historiaToolStripMenuItem";
            historiaToolStripMenuItem.Size = new Size(63, 20);
            historiaToolStripMenuItem.Text = "Historial";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(120, 22);
            reportesToolStripMenuItem.Text = "Reportes";
            reportesToolStripMenuItem.Click += reportesToolStripMenuItem_Click;
            // 
            // cataToolStripMenuItem
            // 
            cataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gruposToolStripMenuItem });
            cataToolStripMenuItem.Name = "cataToolStripMenuItem";
            cataToolStripMenuItem.Size = new Size(67, 20);
            cataToolStripMenuItem.Text = "Catalogo";
            cataToolStripMenuItem.Click += cataToolStripMenuItem_Click;
            // 
            // gruposToolStripMenuItem
            // 
            gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            gruposToolStripMenuItem.Size = new Size(114, 22);
            gruposToolStripMenuItem.Text = "General";
            gruposToolStripMenuItem.Click += gruposToolStripMenuItem_Click;
            // 
            // asistenciaToolStripMenuItem
            // 
            asistenciaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { realizarToolStripMenuItem });
            asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            asistenciaToolStripMenuItem.Size = new Size(72, 20);
            asistenciaToolStripMenuItem.Text = "Asistencia";
            // 
            // realizarToolStripMenuItem
            // 
            realizarToolStripMenuItem.Name = "realizarToolStripMenuItem";
            realizarToolStripMenuItem.Size = new Size(114, 22);
            realizarToolStripMenuItem.Text = "Realizar";
            realizarToolStripMenuItem.Click += realizarToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(302, 18);
            label1.TabIndex = 2;
            label1.Text = "Sistema de Registro de Asistencia";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(91, 83);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 15);
            lblFecha.TabIndex = 3;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(342, 143);
            Controls.Add(lblFecha);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "Menu";
            Load += frmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem historiaToolStripMenuItem;
        private ToolStripMenuItem cataToolStripMenuItem;
        private ToolStripMenuItem gruposToolStripMenuItem;
        private ToolStripMenuItem asistenciaToolStripMenuItem;
        private ToolStripMenuItem realizarToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private Label label1;
        private Label lblFecha;
    }
}
