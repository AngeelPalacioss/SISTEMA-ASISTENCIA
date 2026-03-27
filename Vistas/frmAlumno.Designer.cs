namespace PRAC3_ASISTENCIA.Vistas
{
    partial class frmAlumno
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
            txtControl = new TextBox();
            txtMaterno = new TextBox();
            txtNombre = new TextBox();
            txtPaterno = new TextBox();
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtActivo = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // txtControl
            // 
            txtControl.Location = new Point(12, 91);
            txtControl.Name = "txtControl";
            txtControl.Size = new Size(135, 23);
            txtControl.TabIndex = 0;
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(12, 161);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(135, 23);
            txtMaterno.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(210, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(135, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(405, 91);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(135, 23);
            txtPaterno.TabIndex = 5;
            txtPaterno.TextChanged += textBox6_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(240, 213);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 7;
            label1.Text = "Numero Control:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 60);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 60);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 9;
            label3.Text = "Apellido Paterno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 134);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 10;
            label4.Text = "Apellido Materno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(210, 134);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 11;
            label5.Text = "Grupo(Nombre):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(405, 134);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 12;
            label6.Text = "Activo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 19);
            label7.Name = "label7";
            label7.Size = new Size(218, 29);
            label7.TabIndex = 13;
            label7.Text = "Datos Personales";
            // 
            // txtActivo
            // 
            txtActivo.Enabled = false;
            txtActivo.Location = new Point(405, 161);
            txtActivo.Name = "txtActivo";
            txtActivo.Size = new Size(135, 23);
            txtActivo.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(210, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 14;
            // 
            // frmAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 251);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(txtPaterno);
            Controls.Add(txtActivo);
            Controls.Add(txtNombre);
            Controls.Add(txtMaterno);
            Controls.Add(txtControl);
            Name = "frmAlumno";
            Text = "Agregar Alumno";
            Load += frmAlumno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtActivo;
        private ComboBox comboBox1;
        public TextBox txtControl;
        public TextBox txtMaterno;
        public TextBox txtNombre;
        public TextBox txtPaterno;
    }
}