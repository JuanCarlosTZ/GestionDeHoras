namespace GestionDeHoras
{
    partial class FrmUsuarioAdd
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNo_carnet = new System.Windows.Forms.MaskedTextBox();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.cbxTipo_usuario = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Cédula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 34);
            this.label5.TabIndex = 35;
            this.label5.Text = "Nuevo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "No Carnet";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtNo_carnet);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.cbxEstado);
            this.panel1.Controls.Add(this.cbxTipo_usuario);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(28, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 279);
            this.panel1.TabIndex = 36;
            // 
            // txtNo_carnet
            // 
            this.txtNo_carnet.Location = new System.Drawing.Point(143, 36);
            this.txtNo_carnet.Mask = "999999999";
            this.txtNo_carnet.Name = "txtNo_carnet";
            this.txtNo_carnet.Size = new System.Drawing.Size(183, 22);
            this.txtNo_carnet.TabIndex = 37;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(143, 125);
            this.txtCedula.Mask = "999-0000000-0";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(183, 22);
            this.txtCedula.TabIndex = 36;
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbxEstado.Location = new System.Drawing.Point(143, 206);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(183, 24);
            this.cbxEstado.TabIndex = 35;
            // 
            // cbxTipo_usuario
            // 
            this.cbxTipo_usuario.FormattingEnabled = true;
            this.cbxTipo_usuario.Items.AddRange(new object[] {
            "Estudiante",
            "Empleado"});
            this.cbxTipo_usuario.Location = new System.Drawing.Point(143, 163);
            this.cbxTipo_usuario.Name = "cbxTipo_usuario";
            this.cbxTipo_usuario.Size = new System.Drawing.Size(183, 24);
            this.cbxTipo_usuario.TabIndex = 34;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(143, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 22);
            this.txtNombre.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tipo de Usuario";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Location = new System.Drawing.Point(28, 361);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 49);
            this.panel2.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(50, 13);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 33);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmUsuarioAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 449);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmUsuarioAdd";
            this.Text = "FrmUsuarioAdd";
            this.Load += new System.EventHandler(this.FrmUsuarioAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxTipo_usuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.MaskedTextBox txtNo_carnet;
    }
}