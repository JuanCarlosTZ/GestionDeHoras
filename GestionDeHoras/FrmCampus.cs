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

        public void consultarCampus()
        {
          
            if (cbxCriterio.Text != "" && txtBuscar.Text != "")
            {
                odt = bd.consultar(FrmTipo, cbxCriterio.Text, txtBuscar.Text);
            }
            else
            {
                odt = bd.consultar(FrmTipo);
            }
                dgdCampus.DataSource = odt;
                dgdCampus.Refresh();
            
        }

        

        private void campusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.campusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBUNAPECDataSet1);

        }

        private void FrmCampus_Load(object sender, EventArgs e)
        {
            cargarCriterio();
            consultarCampus();
            
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
            consultarCampus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            consultarCampus();
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

        public void cargarCriterio()
        {
            cbxCriterio.Items.Add("");
            if (bd.conectar())
            {
                List<string> criterio = bd.camposPorTabla(FrmTipo);
                int i = 0;
                while (i < criterio.Count())
                {
                    cbxCriterio.Items.Add(criterio.ElementAt(i));
                    i = i + 1;

                }
            }

        }


    }
}
