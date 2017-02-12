using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeHoras
{
    public partial class FrmCampus : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        SqlConnection ocon = null;
        DataTable odt = new DataTable();
        string FrmTipo = "Campus";
        public FrmCampus()
        {
            InitializeComponent();
        }

        public void consultarCampus(string pCriterio)
        {
            //ocon = bd.getOcon();
            //ocon.Open();
            //string SQL = " Select * From Campus ";
            //SQL += pCriterio;
            //SQL += " Order by " + cbxCriterio.Text;
            //SqlDataAdapter oda = new SqlDataAdapter(SQL, ocon);
            //DataTable odt = new DataTable();
            //oda.Fill(odt);

          
            if (cbxCriterio.Text != "" && txtBuscar.Text != "")
            {
                odt = bd.consultar(FrmTipo, cbxCriterio.Text, txtBuscar.Text);
            }
            else
            {
                odt = bd.consultar(FrmTipo);
            }
            if (odt != null)
            {
                dgdCampus.DataSource = odt;
                dgdCampus.Refresh();
            }
        }

        

        private void campusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.campusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBUNAPECDataSet1);

        }

        private void FrmCampus_Load(object sender, EventArgs e)
        {
            cbxCriterio.SelectedIndex = 0;
            consultarCampus("");
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmCampusAdd add = new FrmCampusAdd();
            add.ShowDialog();
        }

        private void FrmCampus_Activated(object sender, EventArgs e)
        {
            consultarCampus("");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarCampus(" where " + cbxCriterio.Text + " like'%" + txtBuscar.Text + "%'");
        }

        private void dgdCampus_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgdCampus.Rows[0];
            FrmCampusEdit frm = new FrmCampusEdit();
            frm.Identificador = row.Cells[0].Value.ToString();
            frm.Nombre = row.Cells[2].Value.ToString();
            frm.Descripcion = row.Cells[1].Value.ToString();
            frm.Estado = row.Cells[3].Value.ToString();
            frm.ShowDialog();
        }
    }
}
