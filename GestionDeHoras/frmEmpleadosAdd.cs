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
        BaseDeDatos bd = new BaseDeDatos();
        private SqlConnection oCon;
        public frmEmpleadosAdd()
        {
            InitializeComponent();
        }

        private void btnAgragar_Click(object sender, EventArgs e)
        {
            oCon = bd.getOcon();
            oCon.Open();

            string SQL = " Insert into Empleado (Id_empleado, Nombre, cedula,tanda,f_ingreso , Estado) values ( ";
            SQL += "'" + txtIdentificador.Text + "'" + ',';
            SQL += "'" + txtNombre.Text + "'" + ',';
            SQL += "'" + txtCedula.Text + "'" + ',';
            SQL += "'" + cbxTanda.Text + "'" + ',';
            SQL += "'" + txtFchIngreso.Text + "'" + ',';
            SQL += "'" + cbxEstado.Text + "'";
            SQL += ")";

            try
            {
                SqlCommand ocdm = new SqlCommand(SQL, oCon);
                ocdm.ExecuteNonQuery();
                MessageBox.Show("Datos Guardados Correctamente");
                limpiarCampos();
            }
            catch(Exception error)
            {
                MessageBox.Show("Error al guardar los datos");
            }
            
        }
        public void limpiarCampos()
        {
            txtIdentificador.Clear();
            txtNombre.Clear();
            txtFchIngreso.Clear();
            txtCedula.ResetText();
            cbxEstado.ResetText();
            cbxTanda.ResetText();
        }
    }
}
