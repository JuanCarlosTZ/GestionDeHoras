namespace GestionDeHoras
{
    partial class FrmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTextoABuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmdAgregar);
            this.groupBox5.Location = new System.Drawing.Point(544, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(53, 52);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAgregar.BackgroundImage")));
            this.cmdAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAgregar.Location = new System.Drawing.Point(6, 9);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(43, 37);
            this.cmdAgregar.TabIndex = 0;
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdBuscar);
            this.groupBox4.Location = new System.Drawing.Point(460, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(53, 52);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdBuscar.BackgroundImage")));
            this.cmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBuscar.Location = new System.Drawing.Point(6, 9);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(43, 37);
            this.cmdBuscar.TabIndex = 0;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEmpleados);
            this.groupBox2.Location = new System.Drawing.Point(10, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 244);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(7, 18);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(576, 220);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTextoABuscar);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(201, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 52);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // txtTextoABuscar
            // 
            this.txtTextoABuscar.Location = new System.Drawing.Point(49, 17);
            this.txtTextoABuscar.Name = "txtTextoABuscar";
            this.txtTextoABuscar.Size = new System.Drawing.Size(169, 20);
            this.txtTextoABuscar.TabIndex = 1;
            this.txtTextoABuscar.TextChanged += new System.EventHandler(this.txtTextoABuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCriterio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 52);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Items.AddRange(new object[] {
            "Id_empleado",
            "Nombre",
            "cedula",
            "tanda",
            "f_ingreso",
            "Estado"});
            this.cbxCriterio.Location = new System.Drawing.Point(49, 16);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(121, 21);
            this.cbxCriterio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criterio";
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 325);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.Activated += new System.EventHandler(this.FrmEmpleados_Activated);
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTextoABuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Label label1;
    }
}