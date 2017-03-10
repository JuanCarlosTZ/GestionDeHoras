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
    public partial class FrmEdEmpleados : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        private SqlConnection oCon = null;
        public string  Id_empleado = "";
        public string Nombre = "";
        public string cedula = "";
        public string Tanda = "";
        public string f_ingreso = "";
        public string Estado = "";
        public string operacion = "";
        public FrmEdEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEdEmpleados_Load(object sender, EventArgs e)
        {
            

            if (!operacion.Equals("C"))
            {
                txtIdentificador.Text = Id_empleado;
                txtNombre.Text = Nombre;
                txtCedula.Text = cedula;
                cbxTanda.Text = Tanda;
                txtFchIngreso.Text = f_ingreso;
                cbxEstado.Text = Estado;
               
            }

        }

        private void btnAgragar_Click(object sender, EventArgs e)
        {
            string 
                sSQL = "update Empleado ";
                sSQL += " set Nombre =  '" + txtNombre.Text + "',";
                sSQL += " cedula =  '" + txtCedula.Text + "',";
                sSQL += " tanda =  '" + cbxTanda.Text + "',";
                sSQL += " f_ingreso =  '" + txtFchIngreso.Text + "',";
                sSQL += " Estado  =  '" + cbxEstado.Text + "' ";
                sSQL += " where Id_empleado = '" + txtIdentificador.Text + "'";

            if(bd.actualizar(sSQL))
            {
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           
                string sSQL = "delete Empleado";
                sSQL += " where Id_empleado = '" + txtIdentificador.Text + "'";

            if (bd.actualizar(sSQL))
            {
                this.Close();
            }

        }
    }
}
