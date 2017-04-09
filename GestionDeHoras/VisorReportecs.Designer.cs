namespace GestionDeHoras
{
    partial class VisorReportecs
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
            this.rpvSolicitud = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ufnReporteSolicitudTableAdapter1 = new GestionDeHoras.GESTIONDEAULADataSet1TableAdapters.ufnReporteSolicitudTableAdapter();
            this.SuspendLayout();
            // 
            // rpvSolicitud
            // 
            this.rpvSolicitud.AutoSize = true;
            this.rpvSolicitud.Location = new System.Drawing.Point(12, 12);
            this.rpvSolicitud.Name = "rpvSolicitud";
            this.rpvSolicitud.Size = new System.Drawing.Size(1646, 624);
            this.rpvSolicitud.TabIndex = 0;
            // 
            // ufnReporteSolicitudTableAdapter1
            // 
            this.ufnReporteSolicitudTableAdapter1.ClearBeforeFill = true;
            // 
            // VisorReportecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 648);
            this.Controls.Add(this.rpvSolicitud);
            this.Name = "VisorReportecs";
            this.Text = "VisorReportecs";
            this.Load += new System.EventHandler(this.VisorReportecs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvSolicitud;
        private GESTIONDEAULADataSet1TableAdapters.ufnReporteSolicitudTableAdapter ufnReporteSolicitudTableAdapter1;
    }
}