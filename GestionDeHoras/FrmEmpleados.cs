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
    public partial class FrmEmpleados : Form
    {

        SqlConnection ocon = null;
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        public void consultarEmpleados(string pCriterio)
        {
            ocon = new SqlConnection(@"Data Source=WENDY\SQLEXPRESS;Initial Catalog=DBUNAPEC;Integrated Security=True");
            ocon.Open();
            string SQL = " Select * From Empleado";
            SQL += pCriterio;
            SQL += " Order by " + cbxCriterio.Text;
            SqlDataAdapter oda = new SqlDataAdapter(SQL, ocon);
            DataTable odt = new DataTable();
            oda.Fill(odt);
            dgvEmpleados.DataSource = odt;
            dgvEmpleados.Refresh();

        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            cbxCriterio.SelectedIndex = 0;
            consultarEmpleados("");
        }

        private void FrmEmpleados_Activated(object sender, EventArgs e)
        {
            consultarEmpleados("");
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            consultarEmpleados(" where " + cbxCriterio.Text + " like'%" + txtTextoABuscar.Text + "%'");
        }

        private void txtTextoABuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            frmEmpleadosAdd add = new frmEmpleadosAdd();
            add.ShowDialog();
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvEmpleados.SelectedRows[0];
            FrmEdEmpleados frm = new FrmEdEmpleados();
            frm.Id_empleado = row.Cells[0].Value.ToString();
            frm.Nombre = row.Cells[1].Value.ToString();
            frm.cedula = row.Cells[2].Value.ToString();
            frm.tanda = row.Cells[3].Value.ToString();
            frm.f_ingreso = row.Cells[4].Value.ToString();
            frm.tanda= row.Cells[5].Value.ToString();
            frm.operacion = "E";
            frm.ShowDialog();
        }
    }
}
