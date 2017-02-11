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
            this.dBUNAPECDataSet1 = new GestionDeHoras.DBUNAPECDataSet1();
            this.campusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campusTableAdapter = new GestionDeHoras.DBUNAPECDataSet1TableAdapters.CampusTableAdapter();
            this.tableAdapterManager = new GestionDeHoras.DBUNAPECDataSet1TableAdapters.TableAdapterManager();
            this.edificiosTableAdapter = new GestionDeHoras.DBUNAPECDataSet1TableAdapters.EdificiosTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgdCampus = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.fKEdificiosCampusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dBUNAPECDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdCampus)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(9, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 264);
            this.panel1.TabIndex = 0;
            // 
            // dgdCampus
            // 
            this.dgdCampus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdCampus.Location = new System.Drawing.Point(2, 2);
            this.dgdCampus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgdCampus.Name = "dgdCampus";
            this.dgdCampus.RowTemplate.Height = 24;
            this.dgdCampus.Size = new System.Drawing.Size(422, 259);
            this.dgdCampus.TabIndex = 0;
            this.dgdCampus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(377, 24);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(56, 46);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(301, 24);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 46);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // fKEdificiosCampusBindingSource
            // 
            this.fKEdificiosCampusBindingSource.DataMember = "FK_Edificios_Campus";
            this.fKEdificiosCampusBindingSource.DataSource = this.campusBindingSource;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(115, 38);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(170, 20);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Items.AddRange(new object[] {
            "id_campus ",
            "Nombre",
            "Estado",
            "Descripcion"});
            this.cbxCriterio.Location = new System.Drawing.Point(9, 37);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(100, 21);
            this.cbxCriterio.TabIndex = 5;
            // 
            // FrmCampus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 375);
            this.Controls.Add(this.cbxCriterio);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCampus";
            this.Text = "FrmCampus";
            this.Activated += new System.EventHandler(this.FrmCampus_Activated);
            this.Load += new System.EventHandler(this.FrmCampus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBUNAPECDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdCampus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEdificiosCampusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBUNAPECDataSet1 dBUNAPECDataSet1;
        private System.Windows.Forms.BindingSource campusBindingSource;
        private DBUNAPECDataSet1TableAdapters.CampusTableAdapter campusTableAdapter;
        private DBUNAPECDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DBUNAPECDataSet1TableAdapters.EdificiosTableAdapter edificiosTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgdCampus;
        private System.Windows.Forms.BindingSource fKEdificiosCampusBindingSource;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbxCriterio;
    }
}