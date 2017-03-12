namespace GestionDeHoras
{
    partial class frmEmpleadosAdd
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
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgragar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxTanda = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFchIngreso = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.txtIdentificador = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(139, 305);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(207, 24);
            this.cbxEstado.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 34);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nuevo";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(245, 361);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgragar
            // 
            this.btnAgragar.Location = new System.Drawing.Point(69, 361);
            this.btnAgragar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgragar.Name = "btnAgragar";
            this.btnAgragar.Size = new System.Drawing.Size(75, 23);
            this.btnAgragar.TabIndex = 22;
            this.btnAgragar.Text = "&Agregar";
            this.btnAgragar.UseVisualStyleBackColor = true;
            this.btnAgragar.Click += new System.EventHandler(this.btnAgragar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Identificador";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 142);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(207, 22);
            this.txtNombre.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtIdentificador);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.cbxTanda);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(19, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 279);
            this.panel1.TabIndex = 26;
            // 
            // cbxTanda
            // 
            this.cbxTanda.FormattingEnabled = true;
            this.cbxTanda.Location = new System.Drawing.Point(117, 162);
            this.cbxTanda.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTanda.Name = "cbxTanda";
            this.cbxTanda.Size = new System.Drawing.Size(207, 24);
            this.cbxTanda.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tanda";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(19, 347);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 49);
            this.panel2.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cedula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "F.Ingreso";
            // 
            // txtFchIngreso
            // 
            this.txtFchIngreso.Location = new System.Drawing.Point(140, 266);
            this.txtFchIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFchIngreso.Name = "txtFchIngreso";
            this.txtFchIngreso.Size = new System.Drawing.Size(207, 22);
            this.txtFchIngreso.TabIndex = 30;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(120, 125);
            this.txtCedula.Mask = "000-0000000-0";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(204, 22);
            this.txtCedula.TabIndex = 32;
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(117, 33);
            this.txtIdentificador.Mask = "000000000";
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(209, 22);
            this.txtIdentificador.TabIndex = 33;
            // 
            // frmEmpleadosAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFchIngreso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgragar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmpleadosAdd";
            this.Text = "frmEmpleadosAdd";
            this.Load += new System.EventHandler(this.frmEmpleadosAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgragar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxTanda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFchIngreso;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.MaskedTextBox txtIdentificador;
    }
}