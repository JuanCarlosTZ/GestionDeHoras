namespace GestionDeHoras
{
    partial class FrmEdEmpleados
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFchIngreso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgragar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxTanda = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "Edicion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "F.Ingreso";
            // 
            // txtFchIngreso
            // 
            this.txtFchIngreso.Location = new System.Drawing.Point(120, 221);
            this.txtFchIngreso.Margin = new System.Windows.Forms.Padding(2);
            this.txtFchIngreso.Name = "txtFchIngreso";
            this.txtFchIngreso.Size = new System.Drawing.Size(156, 20);
            this.txtFchIngreso.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(119, 157);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(156, 20);
            this.txtCedula.TabIndex = 42;
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbxEstado.Location = new System.Drawing.Point(119, 253);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(156, 21);
            this.cbxEstado.TabIndex = 39;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(199, 298);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(56, 19);
            this.btnLimpiar.TabIndex = 38;
            this.btnLimpiar.Text = "Borrar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgragar
            // 
            this.btnAgragar.Location = new System.Drawing.Point(67, 298);
            this.btnAgragar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgragar.Name = "btnAgragar";
            this.btnAgragar.Size = new System.Drawing.Size(56, 19);
            this.btnAgragar.TabIndex = 37;
            this.btnAgragar.Text = "&Agregar";
            this.btnAgragar.UseVisualStyleBackColor = true;
            this.btnAgragar.Click += new System.EventHandler(this.btnAgragar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Identificador";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 120);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 20);
            this.txtNombre.TabIndex = 33;
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(119, 81);
            this.txtIdentificador.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.ReadOnly = true;
            this.txtIdentificador.Size = new System.Drawing.Size(156, 20);
            this.txtIdentificador.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxTanda);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(29, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 227);
            this.panel1.TabIndex = 40;
            // 
            // cbxTanda
            // 
            this.cbxTanda.FormattingEnabled = true;
            this.cbxTanda.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche"});
            this.cbxTanda.Location = new System.Drawing.Point(88, 132);
            this.cbxTanda.Name = "cbxTanda";
            this.cbxTanda.Size = new System.Drawing.Size(156, 21);
            this.cbxTanda.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tanda";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(29, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 40);
            this.panel2.TabIndex = 41;
            // 
            // FrmEdEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 359);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFchIngreso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgragar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Name = "FrmEdEmpleados";
            this.Text = "FrmEdEmpleados";
            this.Load += new System.EventHandler(this.FrmEdEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFchIngreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgragar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxTanda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
    }
}