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
        public frmEmpleadosAdd()
        {
            InitializeComponent();
        }

        private void btnAgragar_Click(object sender, EventArgs e)
        {
            
                string SQL = " Insert into Empleado (Id_empleado, Nombre, cedula,tanda,f_ingreso , Estado) values ( ";
                SQL += "'" + txtIdentificador.Text + "'" + ',';
                SQL += "'" + txtNombre.Text + "'" + ',';
                SQL += "'" + txtCedula.Text + "'" + ',';
                SQL += "'" + cbxTanda.Text + "'" + ',';
                SQL += "'" + txtFchIngreso.Text + "'" + ',';
                SQL += "'" + cbxEstado.Text + "'";
                SQL += ")";

               if(bd.insertar(SQL))
            {
                this.Close();
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
