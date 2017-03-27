namespace GestionDeHoras
{
    partial class FrmAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAula));
            this.tabControlAula = new System.Windows.Forms.TabControl();
            this.tabPageConsulta = new System.Windows.Forms.TabPage();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgdAula = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabPageMantenimiento = new System.Windows.Forms.TabPage();
            this.dgdEdificio = new System.Windows.Forms.DataGridView();
            this.cbxCriterioEdificio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBuscarEdificio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID_Edificio = new System.Windows.Forms.TextBox();
            this.txtNombreEdificio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID_Aula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.tabControlAula.SuspendLayout();
            this.tabPageConsulta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdAula)).BeginInit();
            this.tabPageMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdEdificio)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAula
            // 
            this.tabControlAula.Controls.Add(this.tabPageConsulta);
            this.tabControlAula.Controls.Add(this.tabPageMantenimiento);
            this.tabControlAula.Location = new System.Drawing.Point(83, 35);
            this.tabControlAula.Name = "tabControlAula";
            this.tabControlAula.SelectedIndex = 0;
            this.tabControlAula.Size = new System.Drawing.Size(908, 483);
            this.tabControlAula.TabIndex = 7;
            // 
            // tabPageConsulta
            // 
            this.tabPageConsulta.Controls.Add(this.cbxCriterio);
            this.tabPageConsulta.Controls.Add(this.panel1);
            this.tabPageConsulta.Controls.Add(this.btnNuevo);
            this.tabPageConsulta.Controls.Add(this.txtBuscar);
            this.tabPageConsulta.Controls.Add(this.btnBuscar);
            this.tabPageConsulta.Location = new System.Drawing.Point(4, 25);
            this.tabPageConsulta.Name = "tabPageConsulta";
            this.tabPageConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsulta.Size = new System.Drawing.Size(900, 454);
            this.tabPageConsulta.TabIndex = 0;
            this.tabPageConsulta.Text = "Consulta";
            this.tabPageConsulta.UseVisualStyleBackColor = true;
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(47, 38);
            this.cbxCriterio.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(132, 24);
            this.cbxCriterio.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgdAula);
            this.panel1.Location = new System.Drawing.Point(45, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 325);
            this.panel1.TabIndex = 0;
            // 
            // dgdAula
            // 
            this.dgdAula.AllowUserToAddRows = false;
            this.dgdAula.AllowUserToDeleteRows = false;
            this.dgdAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdAula.Location = new System.Drawing.Point(4, 27);
            this.dgdAula.Margin = new System.Windows.Forms.Padding(4);
            this.dgdAula.Name = "dgdAula";
            this.dgdAula.ReadOnly = true;
            this.dgdAula.Size = new System.Drawing.Size(560, 271);
            this.dgdAula.TabIndex = 1;
            this.dgdAula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdAula_CellContentClick);
            this.dgdAula.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdAula_CellContentClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(538, 22);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 57);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Agregar";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(188, 39);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(225, 22);
            this.txtBuscar.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(436, 22);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 57);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabPageMantenimiento
            // 
            this.tabPageMantenimiento.Controls.Add(this.dgdEdificio);
            this.tabPageMantenimiento.Controls.Add(this.cbxCriterioEdificio);
            this.tabPageMantenimiento.Controls.Add(this.label8);
            this.tabPageMantenimiento.Controls.Add(this.txtBuscarEdificio);
            this.tabPageMantenimiento.Controls.Add(this.label9);
            this.tabPageMantenimiento.Controls.Add(this.lbTitulo);
            this.tabPageMantenimiento.Controls.Add(this.btnLimpiar);
            this.tabPageMantenimiento.Controls.Add(this.btnAgregar);
            this.tabPageMantenimiento.Controls.Add(this.panel2);
            this.tabPageMantenimiento.Controls.Add(this.panel3);
            this.tabPageMantenimiento.Controls.Add(this.btnBuscarUsuario);
            this.tabPageMantenimiento.Location = new System.Drawing.Point(4, 25);
            this.tabPageMantenimiento.Name = "tabPageMantenimiento";
            this.tabPageMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMantenimiento.Size = new System.Drawing.Size(900, 454);
            this.tabPageMantenimiento.TabIndex = 1;
            this.tabPageMantenimiento.Text = "Mantenimiento";
            this.tabPageMantenimiento.UseVisualStyleBackColor = true;
            // 
            // dgdEdificio
            // 
            this.dgdEdificio.AllowUserToAddRows = false;
            this.dgdEdificio.AllowUserToDeleteRows = false;
            this.dgdEdificio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdEdificio.Location = new System.Drawing.Point(523, 180);
            this.dgdEdificio.Name = "dgdEdificio";
            this.dgdEdificio.ReadOnly = true;
            this.dgdEdificio.RowTemplate.Height = 24;
            this.dgdEdificio.Size = new System.Drawing.Size(240, 150);
            this.dgdEdificio.TabIndex = 62;
            this.dgdEdificio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdEdificio_CellContentClick);
            // 
            // cbxCriterioEdificio
            // 
            this.cbxCriterioEdificio.FormattingEnabled = true;
            this.cbxCriterioEdificio.Location = new System.Drawing.Point(539, 55);
            this.cbxCriterioEdificio.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCriterioEdificio.Name = "cbxCriterioEdificio";
            this.cbxCriterioEdificio.Size = new System.Drawing.Size(160, 24);
            this.cbxCriterioEdificio.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 57;
            this.label8.Text = "Criterio";
            // 
            // txtBuscarEdificio
            // 
            this.txtBuscarEdificio.Location = new System.Drawing.Point(539, 87);
            this.txtBuscarEdificio.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarEdificio.Name = "txtBuscarEdificio";
            this.txtBuscarEdificio.Size = new System.Drawing.Size(224, 22);
            this.txtBuscarEdificio.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 87);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 58;
            this.label9.Text = "Buscar";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(198, 17);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(108, 34);
            this.lbTitulo.TabIndex = 24;
            this.lbTitulo.Text = "Nuevo";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(311, 394);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 34);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(135, 394);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 34);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.nudCapacidad);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtID_Edificio);
            this.panel2.Controls.Add(this.txtNombreEdificio);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbxTipo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbxEstado);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtID_Aula);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Location = new System.Drawing.Point(85, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 318);
            this.panel2.TabIndex = 26;
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(124, 223);
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(207, 22);
            this.nudCapacidad.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Capacidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "ID Edificio";
            // 
            // txtID_Edificio
            // 
            this.txtID_Edificio.Location = new System.Drawing.Point(124, 8);
            this.txtID_Edificio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID_Edificio.Name = "txtID_Edificio";
            this.txtID_Edificio.ReadOnly = true;
            this.txtID_Edificio.Size = new System.Drawing.Size(207, 22);
            this.txtID_Edificio.TabIndex = 28;
            // 
            // txtNombreEdificio
            // 
            this.txtNombreEdificio.Location = new System.Drawing.Point(124, 51);
            this.txtNombreEdificio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreEdificio.Name = "txtNombreEdificio";
            this.txtNombreEdificio.ReadOnly = true;
            this.txtNombreEdificio.Size = new System.Drawing.Size(207, 22);
            this.txtNombreEdificio.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Edificio";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(123, 189);
            this.cbxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(207, 24);
            this.cbxTipo.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tipo";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(124, 260);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(207, 24);
            this.cbxEstado.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Identificador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Estado";
            // 
            // txtID_Aula
            // 
            this.txtID_Aula.Location = new System.Drawing.Point(124, 88);
            this.txtID_Aula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID_Aula.Name = "txtID_Aula";
            this.txtID_Aula.ReadOnly = true;
            this.txtID_Aula.Size = new System.Drawing.Size(207, 22);
            this.txtID_Aula.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(124, 131);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(207, 22);
            this.txtNombre.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(123, 161);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(207, 22);
            this.txtDescripcion.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(85, 381);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 49);
            this.panel3.TabIndex = 27;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarUsuario.BackgroundImage")));
            this.btnBuscarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(796, 63);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(57, 46);
            this.btnBuscarUsuario.TabIndex = 59;
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // FrmAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 586);
            this.Controls.Add(this.tabControlAula);
            this.Name = "FrmAula";
            this.Text = "FrmAula";
            this.Load += new System.EventHandler(this.FrmAula_Load);
            this.tabControlAula.ResumeLayout(false);
            this.tabPageConsulta.ResumeLayout(false);
            this.tabPageConsulta.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdAula)).EndInit();
            this.tabPageMantenimiento.ResumeLayout(false);
            this.tabPageMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdEdificio)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAula;
        private System.Windows.Forms.TabPage tabPageConsulta;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgdAula;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tabPageMantenimiento;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID_Aula;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID_Edificio;
        private System.Windows.Forms.TextBox txtNombreEdificio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgdEdificio;
        private System.Windows.Forms.ComboBox cbxCriterioEdificio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBuscarEdificio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
    }
}