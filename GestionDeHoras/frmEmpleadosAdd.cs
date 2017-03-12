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
        Validar vl = new Validar();
        string frmTipo = new FrmEmpleados().VerFrmTipo();
        DataTable odt = new DataTable();

        public frmEmpleadosAdd()
        {
            InitializeComponent();
        }

        private void btnAgragar_Click(object sender, EventArgs e)
        {
            if (vl.Cedula(txtCedula.Text) && vl.ID(txtIdentificador.Text, "Id_empleado", frmTipo))
            {


                string SQL = " Insert into Empleado (Id_empleado, Nombre, cedula,tanda,f_ingreso , Estado) values ( ";
                SQL += "'" + txtIdentificador.Text + "'" + ',';
                SQL += "'" + txtNombre.Text + "'" + ',';
                SQL += "'" + txtCedula.Text + "'" + ',';
                SQL += "'" + cbxTanda.Text + "'" + ',';
                SQL += "'" + txtFchIngreso.Text + "'" + ',';
                SQL += "'" + cbxEstado.Text + "'";
                SQL += ")";

                if (bd.insertar(SQL))
                {
                    this.Close();
                }
            }
            else
            {
                if (!vl.Cedula(txtCedula.Text))
                {
                    MessageBox.Show("Cédula inválida");
                }
                else
                {
                    MessageBox.Show("Identificador existente");
                }

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
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

        private void frmEmpleadosAdd_Load(object sender, EventArgs e)
        {
            CargarEstado();
            CargarTanda();
        }
    }
}
