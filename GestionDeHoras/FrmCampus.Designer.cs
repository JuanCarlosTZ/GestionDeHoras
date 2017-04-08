namespace GestionDeHoras
{
    partial class FrmCampus
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCampus));
            this.dBUNAPECDataSet1 = new GestionDeHoras.DBUNAPECDataSet1();
            this.campusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campusTableAdapter = new GestionDeHoras.DBUNAPECDataSet1TableAdapters.CampusTableAdapter();
            this.tableAdapterManager = new GestionDeHoras.DBUNAPECDataSet1TableAdapters.TableAdapterManager();
            this.edificiosTableAdapter = new GestionDeHoras.DBUNAPECDataSet1TableAdapters.EdificiosTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgdCampus = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.tabControlCampus = new System.Windows.Forms.TabControl();
            this.tabPageConsulta = new System.Windows.Forms.TabPage();
            this.tabPageMantenimiento = new System.Windows.Forms.TabPage();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fKEdificiosCampusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dBUNAPECDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdCampus)).BeginInit();
            this.tabControlCampus.SuspendLayout();
            this.tabPageConsulta.SuspendLayout();
            this.tabPageMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKEdificiosCampusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dBUNAPECDataSet1
            // 
            this.dBUNAPECDataSet1.DataSetName = "DBUNAPECDataSet1";
            this.dBUNAPECDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // campusBindingSource
            // 
            this.campusBindingSource.DataMember = "Campus";
            this.campusBindingSource.DataSource = this.dBUNAPECDataSet1;
            // 
            // campusTableAdapter
            // 
            this.campusTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AulasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CampusTableAdapter = this.campusTableAdapter;
            this.tableAdapterManager.EdificiosTableAdapter = this.edificiosTableAdapter;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.ReservacionesTableAdapter = null;
            this.tableAdapterManager.Tipo_AulasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionDeHoras.DBUNAPECDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // edificiosTableAdapter
            // 
            this.edificiosTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgdCampus);
            this.panel1.Location = new System.Drawing.Point(45, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 325);
            this.panel1.TabIndex = 0;
            // 
            // dgdCampus
            // 
            this.dgdCampus.AllowUserToAddRows = false;
            this.dgdCampus.AllowUserToDeleteRows = false;
            this.dgdCampus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdCampus.Location = new System.Drawing.Point(4, 27);
            this.dgdCampus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgdCampus.Name = "dgdCampus";
            this.dgdCampus.ReadOnly = true;
            this.dgdCampus.Size = new System.Drawing.Size(560, 271);
            this.dgdCampus.TabIndex = 1;
            this.dgdCampus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdCampus_CellContentClick);
            this.dgdCampus.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdCampus_CellContentDoubleClick);
            this.dgdCampus.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdCampus_CellContentDoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(539, 22);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 57);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Agregar";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnAgregar_Click);
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
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(188, 39);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(225, 22);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(47, 38);
            this.cbxCriterio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(132, 24);
            this.cbxCriterio.TabIndex = 5;
            // 
            // tabControlCampus
            // 
            this.tabControlCampus.Controls.Add(this.tabPageConsulta);
            this.tabControlCampus.Controls.Add(this.tabPageMantenimiento);
            this.tabControlCampus.Location = new System.Drawing.Point(35, 30);
            this.tabControlCampus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlCampus.Name = "tabControlCampus";
            this.tabControlCampus.SelectedIndex = 0;
            this.tabControlCampus.Size = new System.Drawing.Size(707, 482);
            this.tabControlCampus.TabIndex = 6;
            // 
            // tabPageConsulta
            // 
            this.tabPageConsulta.BackColor = System.Drawing.Color.Transparent;
            this.tabPageConsulta.Controls.Add(this.cbxCriterio);
            this.tabPageConsulta.Controls.Add(this.panel1);
            this.tabPageConsulta.Controls.Add(this.btnNuevo);
            this.tabPageConsulta.Controls.Add(this.txtBuscar);
            this.tabPageConsulta.Controls.Add(this.btnBuscar);
            this.tabPageConsulta.Location = new System.Drawing.Point(4, 25);
            this.tabPageConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageConsulta.Name = "tabPageConsulta";
            this.tabPageConsulta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageConsulta.Size = new System.Drawing.Size(699, 453);
            this.tabPageConsulta.TabIndex = 0;
            this.tabPageConsulta.Text = "Consulta";
            // 
            // tabPageMantenimiento
            // 
            this.tabPageMantenimiento.Controls.Add(this.cbxEstado);
            this.tabPageMantenimiento.Controls.Add(this.lbTitulo);
            this.tabPageMantenimiento.Controls.Add(this.btnLimpiar);
            this.tabPageMantenimiento.Controls.Add(this.btnAgregar);
            this.tabPageMantenimiento.Controls.Add(this.label4);
            this.tabPageMantenimiento.Controls.Add(this.label3);
            this.tabPageMantenimiento.Controls.Add(this.label2);
            this.tabPageMantenimiento.Controls.Add(this.label1);
            this.tabPageMantenimiento.Controls.Add(this.txtDescripcion);
            this.tabPageMantenimiento.Controls.Add(this.txtNombre);
            this.tabPageMantenimiento.Controls.Add(this.txtIdentificador);
            this.tabPageMantenimiento.Controls.Add(this.panel2);
            this.tabPageMantenimiento.Controls.Add(this.panel3);
            this.tabPageMantenimiento.Location = new System.Drawing.Point(4, 25);
            this.tabPageMantenimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMantenimiento.Name = "tabPageMantenimiento";
            this.tabPageMantenimiento.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMantenimiento.Size = new System.Drawing.Size(699, 453);
            this.tabPageMantenimiento.TabIndex = 1;
            this.tabPageMantenimiento.Text = "Mantenimiento";
            this.tabPageMantenimiento.UseVisualStyleBackColor = true;
            this.tabPageMantenimiento.Click += new System.EventHandler(this.tabPageMantenimiento_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(205, 233);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(207, 24);
            this.cbxEstado.TabIndex = 25;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(197, 53);
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
            this.btnAgregar.Click += new System.EventHandler(this.btnAgragar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Estado";
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
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(205, 279);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(207, 22);
            this.txtDescripcion.TabIndex = 17;
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
            this.panel2.Location = new System.Drawing.Point(85, 102);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 214);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(85, 334);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 49);
            this.panel3.TabIndex = 27;
            // 
            // fKEdificiosCampusBindingSource
            // 
            this.fKEdificiosCampusBindingSource.DataMember = "FK_Edificios_Campus";
            this.fKEdificiosCampusBindingSource.DataSource = this.campusBindingSource;
            // 
            // FrmCampus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::GestionDeHoras.Properties.Resources._14435003726_1dd7a23465_o;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 526);
            this.Controls.Add(this.tabControlCampus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCampus";
            this.Text = "Campus";
            this.Activated += new System.EventHandler(this.FrmCampus_Activated);
            this.Load += new System.EventHandler(this.FrmCampus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBUNAPECDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdCampus)).EndInit();
            this.tabControlCampus.ResumeLayout(false);
            this.tabPageConsulta.ResumeLayout(false);
            this.tabPageConsulta.PerformLayout();
            this.tabPageMantenimiento.ResumeLayout(false);
            this.tabPageMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKEdificiosCampusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBUNAPECDataSet1 dBUNAPECDataSet1;
        private System.Windows.Forms.BindingSource campusBindingSource;
        private DBUNAPECDataSet1TableAdapters.CampusTableAdapter campusTableAdapter;
        private DBUNAPECDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DBUNAPECDataSet1TableAdapters.EdificiosTableAdapter edificiosTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource fKEdificiosCampusBindingSource;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.TabControl tabControlCampus;
        private System.Windows.Forms.TabPage tabPageConsulta;
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
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgdCampus;
    }
}