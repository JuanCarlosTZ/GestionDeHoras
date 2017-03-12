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
        DataTable odt = new DataTable();
        Validar vl = new Validar();
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

            CargarEstado();
            CargarTanda();
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
            if (vl.Cedula(txtCedula.Text))
            {


                string
                    sSQL = "update Empleado ";
                sSQL += " set Nombre =  '" + txtNombre.Text + "',";
                sSQL += " cedula =  '" + txtCedula.Text + "',";
                sSQL += " tanda =  '" + cbxTanda.Text + "',";
                sSQL += " f_ingreso =  '" + txtFchIngreso.Text + "',";
                sSQL += " Estado  =  '" + cbxEstado.Text + "' ";
                sSQL += " where Id_empleado = '" + txtIdentificador.Text + "'";

                if (bd.actualizar(sSQL))
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Cédula inválida");
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

        public void CargarTanda()
        {
            if (bd.conectar())
            {
                odt = bd.consultar("Tanda");
                List<string> tipoUsuario = odt.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Nombre")).ToList();
                int i = 0;
                cbxTanda.Items.Add("");
                while (i < tipoUsuario.Count())
                {
                    cbxTanda.Items.Add(tipoUsuario.ElementAt(i));
                    i = i + 1;

                }
            }

        }

        public void CargarEstado()
        {
            if (bd.conectar())
            {
                odt = bd.consultar("Estado_Usuario");
                List<string> estadoUsuario = odt.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Nombre")).ToList();
                int i = 0;
                cbxEstado.Items.Add("");
                while (i < estadoUsuario.Count())
                {
                    cbxEstado.Items.Add(estadoUsuario.ElementAt(i));
                    i = i + 1;

                }
            }

        }
    }
}
