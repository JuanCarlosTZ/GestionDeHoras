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
    public partial class frmEmpleadosAdd : Form
    {
        private SqlConnection oCon = null;
        public frmEmpleadosAdd()
        {
            InitializeComponent();
        }

        private void btnAgragar_Click(object sender, EventArgs e)
        {
            SqlConnection oCon = new SqlConnection(@"Data Source=WENDY\SQLEXPRESS;Initial Catalog=DBUNAPEC;Integrated Security=True");
            oCon.Open();

            string SQL = " Insert into Empleado (Id_empleado, Nombre, cedula,tanda,f_ingreso , Estado) values ( ";
            SQL += "'" + txtIdentificador.Text + "'" + ',';
            SQL += "'" + txtNombre.Text + "'" + ',';
            SQL += "'" + txtCedula.Text + "'" + ',';
            SQL += "'" + cbxTanda.Text + "'" + ',';
            SQL += "'" + txtFchIngreso.Text + "'" + ',';
            SQL += "'" + cbxEstado.Text + "'";
            SQL += ")";

            SqlCommand ocdm = new SqlCommand(SQL, oCon);
            ocdm.ExecuteNonQuery();
            MessageBox.Show("Datos Guardados Correctamente");
            this.Close();
        }
    }
}
