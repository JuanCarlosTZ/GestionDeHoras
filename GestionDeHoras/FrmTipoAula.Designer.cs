namespace GestionDeHoras
{
    partial class FrmTipoAula
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
            this.tabControlTipoAula = new System.Windows.Forms.TabControl();
            this.tabPageConsulta = new System.Windows.Forms.TabPage();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgdTipoAula = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabPageMantenimiento = new System.Windows.Forms.TabPage();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControlTipoAula.SuspendLayout();
            this.tabPageConsulta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdTipoAula)).BeginInit();
            this.tabPageMantenimiento.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTipoAula
            // 
            this.tabControlTipoAula.Controls.Add(this.tabPageConsulta);
            this.tabControlTipoAula.Controls.Add(this.tabPageMantenimiento);
            this.tabControlTipoAula.Location = new System.Drawing.Point(49, 47);
            this.tabControlTipoAula.Name = "tabControlTipoAula";
            this.tabControlTipoAula.SelectedIndex = 0;
            this.tabControlTipoAula.Size = new System.Drawing.Size(706, 483);
            this.tabControlTipoAula.TabIndex = 8;
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
            this.tabPageConsulta.Size = new System.Drawing.Size(698, 454);
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
            this.panel1.Controls.Add(this.dgdTipoAula);
            this.panel1.Location = new System.Drawing.Point(45, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 325);
            this.panel1.TabIndex = 0;
            // 
            // dgdTipoAula
            // 
            this.dgdTipoAula.AllowUserToAddRows = false;
            this.dgdTipoAula.AllowUserToDeleteRows = false;
            this.dgdTipoAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdTipoAula.Location = new System.Drawing.Point(4, 27);
            this.dgdTipoAula.Margin = new System.Windows.Forms.Padding(4);
            this.dgdTipoAula.Name = "dgdTipoAula";
            this.dgdTipoAula.ReadOnly = true;
            this.dgdTipoAula.Size = new System.Drawing.Size(560, 271);
            this.dgdTipoAula.TabIndex = 1;
            this.dgdTipoAula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdTipoAula_CellContentClick);
            this.dgdTipoAula.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdTipoAula_CellContentClick);
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
            this.tabPageMantenimiento.Controls.Add(this.lbTitulo);
            this.tabPageMantenimiento.Controls.Add(this.btnLimpiar);
            this.tabPageMantenimiento.Controls.Add(this.btnAgregar);
            this.tabPageMantenimiento.Controls.Add(this.label2);
            this.tabPageMantenimiento.Controls.Add(this.label1);
            this.tabPageMantenimiento.Controls.Add(this.txtNombre);
            this.tabPageMantenimiento.Controls.Add(this.txtIdentificador);
            this.tabPageMantenimiento.Controls.Add(this.panel2);
            this.tabPageMantenimiento.Controls.Add(this.panel3);
            this.tabPageMantenimiento.Location = new System.Drawing.Point(4, 25);
            this.tabPageMantenimiento.Name = "tabPageMantenimiento";
            this.tabPageMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMantenimiento.Size = new System.Drawing.Size(698, 454);
            this.tabPageMantenimiento.TabIndex = 1;
            this.tabPageMantenimiento.Text = "Mantenimiento";
            this.tabPageMantenimiento.UseVisualStyleBackColor = true;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(198, 53);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(108, 34);
            this.lbTitulo.TabIndex = 24;
            this.lbTitulo.Text = "Nuevo";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(311, 347);
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
            this.btnAgregar.Location = new System.Drawing.Point(135, 347);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 34);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Identificador";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(205, 188);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(207, 22);
            this.txtNombre.TabIndex = 16;
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(205, 135);
            this.txtIdentificador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.ReadOnly = true;
            this.txtIdentificador.Size = new System.Drawing.Size(207, 22);
            this.txtIdentificador.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(85, 102);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 214);
            this.panel2.TabIndex = 26;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(119, 126);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(207, 22);
            this.txtDescripcion.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Descripción";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(85, 334);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 49);
            this.panel3.TabIndex = 27;
            // 
            // FrmTipoAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 576);
            this.Controls.Add(this.tabControlTipoAula);
            this.Name = "FrmTipoAula";
            this.Text = "FrmTipoAula";
            this.Load += new System.EventHandler(this.FrmTipoAula_Load);
            this.tabControlTipoAula.ResumeLayout(false);
            this.tabPageConsulta.ResumeLayout(false);
            this.tabPageConsulta.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdTipoAula)).EndInit();
            this.tabPageMantenimiento.ResumeLayout(false);
            this.tabPageMantenimiento.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTipoAula;
        private System.Windows.Forms.TabPage tabPageConsulta;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgdTipoAula;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tabPageMantenimiento;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
    }
}