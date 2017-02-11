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
        private SqlConnection oCon = null;
        public string  Id_empleado = "";
        public string Nombre = "";
        public string cedula = "";
        public string tanda = "";
        public string f_ingreso = "";
        public string Estado = "";
        public string operacion = "";
        public FrmEdEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEdEmpleados_Load(object sender, EventArgs e)
        {
            oCon = new SqlConnection(@"Data Source=WENDY\SQLEXPRESS;Initial Catalog=DBUNAPEC;Integrated Security=True");
            oCon.Open();

            if (!operacion.Equals("C"))
            {
                txtIdentificador.Text = Id_empleado;
                txtNombre.Text = Nombre;
                txtCedula.Text = cedula;
                if (tanda.Equals("Mañana"))
                    cbxTanda.SelectedIndex = 0;
                else if(tanda.Equals("Tarde"))
                {
                    cbxTanda.SelectedIndex = 1;
                }
                else
                    cbxTanda.SelectedIndex = 2;
                txtFchIngreso.Text = f_ingreso;

                if (Estado.Equals("Activo"))
                    cbxEstado.SelectedIndex = 0;
                      else
                    cbxEstado.SelectedIndex = 1;


            }

        }

        private void btnAgragar_Click(object sender, EventArgs e)
        {
            string sSQL = "";
            if (operacion.Equals("C"))
            {
                sSQL = "insert into Empleado";
                sSQL += " (Id_empleado, Nombre, cedula, tanda,f_ingreso,Estado) ";
                sSQL += " values ('" + txtIdentificador.Text + "','" + txtNombre.Text + "','";
                sSQL +=  txtCedula.Text + "','" + cbxTanda.Text + "','";
                sSQL += txtFchIngreso.Text + "', '" + cbxTanda.Text + "')";
            }
            else
            {
                sSQL = "update Empleado ";
                sSQL += " set Nombre =  '" + txtNombre.Text + "',";
                sSQL += " cedula =  '" + txtCedula.Text + "',";
                sSQL += " tanda =  '" + cbxTanda.Text + "',";
                sSQL += " f_ingreso =  '" + txtFchIngreso.Text + "',";
                sSQL += " Estado  =  '" + cbxEstado.Text + "' ";
                sSQL += " where Id_empleado = '" + txtIdentificador.Text + "'";
            }

            SqlCommand oCmd = new SqlCommand(sSQL, oCon);
            oCmd.ExecuteNonQuery();
            MessageBox.Show("Registro guardado con exito");
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                string sSQL = "delete Empleado";
                sSQL += " where Id_empleado = '" + txtIdentificador.Text + "'";
                SqlCommand oCmd = new SqlCommand(sSQL, oCon);
                oCmd.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado con exito");
                this.Close();
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
            }
        }
    }
}
