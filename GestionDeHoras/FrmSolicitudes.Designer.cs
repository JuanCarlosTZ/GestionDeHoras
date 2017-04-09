namespace GestionDeHoras
{
    partial class FrmSolicitudes
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
            this.tabControlSolicitud = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscarMiSolicitud = new System.Windows.Forms.Button();
            this.dgdMiSolicitud = new System.Windows.Forms.DataGridView();
            this.txtValorMiSolicitud = new System.Windows.Forms.TextBox();
            this.cbxCriterioMiSolicitud = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxEdificio = new System.Windows.Forms.ComboBox();
            this.cbxCampus = new System.Windows.Forms.ComboBox();
            this.dgdAula = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtFechaReservacion = new System.Windows.Forms.MaskedTextBox();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID_Aula = new System.Windows.Forms.TextBox();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControlSolicitud.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdMiSolicitud)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdAula)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSolicitud
            // 
            this.tabControlSolicitud.Controls.Add(this.tabPage1);
            this.tabControlSolicitud.Controls.Add(this.tabPage2);
            this.tabControlSolicitud.Location = new System.Drawing.Point(52, 56);
            this.tabControlSolicitud.Name = "tabControlSolicitud";
            this.tabControlSolicitud.SelectedIndex = 0;
            this.tabControlSolicitud.Size = new System.Drawing.Size(919, 512);
            this.tabControlSolicitud.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(911, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Solicitudes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnNuevo);
            this.panel6.Controls.Add(this.btnBuscarMiSolicitud);
            this.panel6.Controls.Add(this.dgdMiSolicitud);
            this.panel6.Controls.Add(this.txtValorMiSolicitud);
            this.panel6.Controls.Add(this.cbxCriterioMiSolicitud);
            this.panel6.Location = new System.Drawing.Point(40, 69);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(794, 340);
            this.panel6.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(317, 176);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarMiSolicitud
            // 
            this.btnBuscarMiSolicitud.Location = new System.Drawing.Point(236, 177);
            this.btnBuscarMiSolicitud.Name = "btnBuscarMiSolicitud";
            this.btnBuscarMiSolicitud.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMiSolicitud.TabIndex = 3;
            this.btnBuscarMiSolicitud.Text = "Buscar";
            this.btnBuscarMiSolicitud.UseVisualStyleBackColor = true;
            this.btnBuscarMiSolicitud.Click += new System.EventHandler(this.btnBuscarMiSolicitud_Click);
            // 
            // dgdMiSolicitud
            // 
            this.dgdMiSolicitud.AllowUserToAddRows = false;
            this.dgdMiSolicitud.AllowUserToDeleteRows = false;
            this.dgdMiSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdMiSolicitud.Location = new System.Drawing.Point(3, 206);
            this.dgdMiSolicitud.Name = "dgdMiSolicitud";
            this.dgdMiSolicitud.ReadOnly = true;
            this.dgdMiSolicitud.RowTemplate.Height = 24;
            this.dgdMiSolicitud.Size = new System.Drawing.Size(788, 132);
            this.dgdMiSolicitud.TabIndex = 0;
            // 
            // txtValorMiSolicitud
            // 
            this.txtValorMiSolicitud.Location = new System.Drawing.Point(130, 178);
            this.txtValorMiSolicitud.Name = "txtValorMiSolicitud";
            this.txtValorMiSolicitud.Size = new System.Drawing.Size(100, 22);
            this.txtValorMiSolicitud.TabIndex = 2;
            // 
            // cbxCriterioMiSolicitud
            // 
            this.cbxCriterioMiSolicitud.FormattingEnabled = true;
            this.cbxCriterioMiSolicitud.Location = new System.Drawing.Point(3, 176);
            this.cbxCriterioMiSolicitud.Name = "cbxCriterioMiSolicitud";
            this.cbxCriterioMiSolicitud.Size = new System.Drawing.Size(121, 24);
            this.cbxCriterioMiSolicitud.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(43, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar Solicitud";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cbxEdificio);
            this.tabPage2.Controls.Add(this.cbxCampus);
            this.tabPage2.Controls.Add(this.dgdAula);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnLimpiar);
            this.tabPage2.Controls.Add(this.btnAgregar);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(911, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nueva";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Edificio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Campus";
            // 
            // cbxEdificio
            // 
            this.cbxEdificio.FormattingEnabled = true;
            this.cbxEdificio.Location = new System.Drawing.Point(546, 202);
            this.cbxEdificio.Name = "cbxEdificio";
            this.cbxEdificio.Size = new System.Drawing.Size(186, 24);
            this.cbxEdificio.TabIndex = 35;
            this.cbxEdificio.SelectedIndexChanged += new System.EventHandler(this.cbxEdificio_SelectedIndexChanged);
            // 
            // cbxCampus
            // 
            this.cbxCampus.FormattingEnabled = true;
            this.cbxCampus.Location = new System.Drawing.Point(546, 160);
            this.cbxCampus.Name = "cbxCampus";
            this.cbxCampus.Size = new System.Drawing.Size(186, 24);
            this.cbxCampus.TabIndex = 34;
            this.cbxCampus.SelectedIndexChanged += new System.EventHandler(this.cbxCampus_SelectedIndexChanged);
            // 
            // dgdAula
            // 
            this.dgdAula.AllowUserToAddRows = false;
            this.dgdAula.AllowUserToDeleteRows = false;
            this.dgdAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdAula.Location = new System.Drawing.Point(475, 249);
            this.dgdAula.Name = "dgdAula";
            this.dgdAula.ReadOnly = true;
            this.dgdAula.RowTemplate.Height = 24;
            this.dgdAula.Size = new System.Drawing.Size(358, 150);
            this.dgdAula.TabIndex = 33;
            this.dgdAula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdAula_CellContentClick);
            this.dgdAula.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdAula_CellContentDoubleClick);
            this.dgdAula.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdAula_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 34);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nueva";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(305, 410);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 34);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(129, 410);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 34);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtFechaReservacion);
            this.panel4.Controls.Add(this.nudHoras);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtID_Aula);
            this.panel4.Controls.Add(this.txtAula);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtComentario);
            this.panel4.Location = new System.Drawing.Point(79, 71);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 318);
            this.panel4.TabIndex = 31;
            // 
            // txtFechaReservacion
            // 
            this.txtFechaReservacion.Location = new System.Drawing.Point(125, 123);
            this.txtFechaReservacion.Mask = "0000/00/00 90:\\0\\0";
            this.txtFechaReservacion.Name = "txtFechaReservacion";
            this.txtFechaReservacion.Size = new System.Drawing.Size(208, 22);
            this.txtFechaReservacion.TabIndex = 42;
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(126, 164);
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(207, 22);
            this.nudHoras.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Horas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "ID Aula";
            // 
            // txtID_Aula
            // 
            this.txtID_Aula.Location = new System.Drawing.Point(125, 27);
            this.txtID_Aula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID_Aula.Name = "txtID_Aula";
            this.txtID_Aula.ReadOnly = true;
            this.txtID_Aula.Size = new System.Drawing.Size(207, 22);
            this.txtID_Aula.TabIndex = 28;
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(125, 70);
            this.txtAula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAula.Name = "txtAula";
            this.txtAula.ReadOnly = true;
            this.txtAula.Size = new System.Drawing.Size(207, 22);
            this.txtAula.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Aula";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Comentario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 34);
            this.label11.TabIndex = 19;
            this.label11.Text = "Fecha\r\nReservación";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(35, 228);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(297, 68);
            this.txtComentario.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(79, 397);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(365, 49);
            this.panel5.TabIndex = 32;
            // 
            // FrmSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1838, 920);
            this.Controls.Add(this.tabControlSolicitud);
            this.Name = "FrmSolicitudes";
            this.Text = "FrmSolicitudes";
            this.Load += new System.EventHandler(this.FrmSolicitudes_Load);
            this.tabControlSolicitud.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdMiSolicitud)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdAula)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSolicitud;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBuscarMiSolicitud;
        private System.Windows.Forms.TextBox txtValorMiSolicitud;
        private System.Windows.Forms.ComboBox cbxCriterioMiSolicitud;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgdMiSolicitud;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID_Aula;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEdificio;
        private System.Windows.Forms.ComboBox cbxCampus;
        private System.Windows.Forms.DataGridView dgdAula;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.MaskedTextBox txtFechaReservacion;
        private System.Windows.Forms.Button btnCancelar;
    }
}