﻿namespace GestionDeHoras
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
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 34);
            this.label5.TabIndex = 24;
            this.label5.Text = "Edicion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "F.Ingreso";
            // 
            // txtFchIngreso
            // 
            this.txtFchIngreso.Location = new System.Drawing.Point(160, 272);
            this.txtFchIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFchIngreso.Name = "txtFchIngreso";
            this.txtFchIngreso.Size = new System.Drawing.Size(207, 22);
            this.txtFchIngreso.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Cedula";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(159, 311);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(207, 24);
            this.cbxEstado.TabIndex = 39;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(265, 367);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 38;
            this.btnLimpiar.Text = "Borrar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgragar
            // 
            this.btnAgragar.Location = new System.Drawing.Point(89, 367);
            this.btnAgragar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgragar.Name = "btnAgragar";
            this.btnAgragar.Size = new System.Drawing.Size(75, 23);
            this.btnAgragar.TabIndex = 37;
            this.btnAgragar.Text = "&Agregar";
            this.btnAgragar.UseVisualStyleBackColor = true;
            this.btnAgragar.Click += new System.EventHandler(this.btnAgragar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Identificador";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(159, 148);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(207, 22);
            this.txtNombre.TabIndex = 33;
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(159, 100);
            this.txtIdentificador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.ReadOnly = true;
            this.txtIdentificador.Size = new System.Drawing.Size(207, 22);
            this.txtIdentificador.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.cbxTanda);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(39, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 279);
            this.panel1.TabIndex = 40;
            // 
            // cbxTanda
            // 
            this.cbxTanda.FormattingEnabled = true;
            this.cbxTanda.Location = new System.Drawing.Point(117, 162);
            this.cbxTanda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.panel2.Location = new System.Drawing.Point(39, 353);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 49);
            this.panel2.TabIndex = 41;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(120, 124);
            this.txtCedula.Mask = "000-0000000-0";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(207, 22);
            this.txtCedula.TabIndex = 32;
            // 
            // FrmEdEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 442);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFchIngreso);
            this.Controls.Add(this.label6);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.MaskedTextBox txtCedula;
    }
}