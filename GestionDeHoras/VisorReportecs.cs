using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeHoras
{
    public partial class VisorReportecs : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        DataTable  odt =  new DataTable();
        public VisorReportecs()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VisorReportecs_Load(object sender, EventArgs e)
        {
            odt = bd.getReporteSolicitud();
            ReportDataSource rds = new ReportDataSource();
            rds.Value = odt;
            rds.Name = "Solicitud";
            rpvSolicitud.LocalReport.DataSources.Clear();
            rpvSolicitud.LocalReport.DataSources.Add(rds);
            rpvSolicitud.LocalReport.ReportEmbeddedResource = "Report1.rdlc";
            rpvSolicitud.LocalReport.ReportPath = "Report1.rdlc";
            rpvSolicitud.LocalReport.Refresh();

            this.rpvSolicitud.RefreshReport();



            //SqlDataAdapter oda = new SqlDataAdapter(sSQL, ocon);
            //DataTable odt = new DataTable();
            //oda.Fill(odt);

            //ReportDataSource rds = new ReportDataSource();
            //rds.Value = odt;
            //rds.Name = "DataSet1";
            //rpvReporte.LocalReport.DataSources.Clear();
            //rpvReporte.LocalReport.DataSources.Add(rds);
            //rpvReporte.LocalReport.ReportEmbeddedResource = "Report1.rdlc";
            //rpvReporte.LocalReport.ReportPath = @"Report1.rdlc";
            //rpvReporte.LocalReport.Refresh();
            //rpvReporte.RefreshReport();
        }
    }
}
