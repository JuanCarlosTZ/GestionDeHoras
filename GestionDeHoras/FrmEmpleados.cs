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
        BaseDeDatos bd = new BaseDeDatos();
        SqlConnection ocon;
        DataTable odt;
        string FrmTipo = "Empleado";
        
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        public string VerFrmTipo()
        {
            return FrmTipo;
        }

        public void consultarEmpleados()
        {

            if (bd.conectar())
            {
                string vCriterio = txtTextoABuscar.Text;
                string pCriterio = cbxCriterio.Text; 
                if (pCriterio != "" || vCriterio != "")
                {
                    odt = bd.consultar(FrmTipo, pCriterio,vCriterio);

                }
                else
                {
                    odt = bd.consultar(FrmTipo);
                }

                dgvEmpleados.DataSource = odt;
                dgvEmpleados.Refresh();
            }

        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            cargarCriterio();
            consultarEmpleados();
        }

        private void FrmEmpleados_Activated(object sender, EventArgs e)
        {
            //consultarEmpleados();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            consultarEmpleados();
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
            DataGridViewRow row = this.dgvEmpleados.Rows[0];
            FrmEdEmpleados frm = new FrmEdEmpleados();
            frm.Id_empleado = row.Cells[0].Value.ToString();
            frm.Nombre = row.Cells[1].Value.ToString();
            frm.cedula = row.Cells[2].Value.ToString();
            frm.Tanda = row.Cells[3].Value.ToString();
            frm.f_ingreso = row.Cells[4].Value.ToString();
            frm.Estado= row.Cells[5].Value.ToString();
            frm.operacion = "E";
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
