using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeHoras
{
    public partial class FrmUsuarioAdd : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        Validar vl = new Validar();
        string frmTipo = new FrmUsuario().VerFrmTipo();
        DataTable odt = new DataTable();
       

        public FrmUsuarioAdd()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (vl.Cedula(txtCedula.Text) && vl.ID(txtNo_carnet.Text, "No_Carnet", frmTipo))
            {

                string SQL = " Insert into Usuario (No_carnet, Nombre, Cedula,Tipo_usuario,Estado) values ( ";
                SQL += "'" + txtNo_carnet.Text + "'" + ',';
                SQL += "'" + txtNombre.Text + "'" + ',';
                SQL += "'" + txtCedula.Text + "'" + ',';
                SQL += "'" + cbxTipo_usuario.Text + "'" + ',';
                SQL += "'" + cbxEstado.Text + "'";
                SQL += ")";

                if (bd.insertar(SQL))
                {
                    limpiarCampos();
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
            txtNo_carnet.Clear();
            txtNombre.Clear();
            txtCedula.ResetText();
            cbxEstado.ResetText();
            cbxTipo_usuario.ResetText();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void FrmUsuarioAdd_Load(object sender, EventArgs e)
        {
            CargarTipoUsuario();
            CargarEstado();
        }
        public void CargarTipoUsuario()
        {
            if (bd.conectar())
            {
                odt = bd.consultar("Tipo_Usuario");
                List<string> tipoUsuario = odt.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Nombre")).ToList();
                int i = 0;
                cbxTipo_usuario.Items.Add("");
                while (i < tipoUsuario.Count())
                {
                    cbxTipo_usuario.Items.Add(tipoUsuario.ElementAt(i));
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
