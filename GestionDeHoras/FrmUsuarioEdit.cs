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
    public partial class FrmUsuarioEdit : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        DataTable odt = new DataTable();
        Validar vl = new Validar();
        public string No_carnet = "";
        public string Nombre = "";
        public string Cedula = "";
        public string Tipo_usuario = "";
        public string Estado = "";
        string frmTipo = new FrmUsuario().VerFrmTipo();
        public FrmUsuarioEdit()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (vl.Cedula(txtCedula.Text))
            {

                string SQL;

                SQL = "update Usuario ";
                SQL += " set Nombre =  '" + txtNombre.Text + "',";
                SQL += " Cedula =  '" + txtCedula.Text + "',";
                SQL += " Tipo_usuario =  '" + cbxTipo_usuario.Text + "',";
                SQL += " Estado  =  '" + cbxEstado.Text + "' ";
                SQL += " where No_carnet = '" + txtNo_carnet.Text + "'";

                if (bd.actualizar(SQL))
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Cédula inválida");
            }
        }

        private void FrmUsuarioEdit_Load(object sender, EventArgs e)
        {
            CargarEstado();
            CargarTipoUsuario();

            txtNo_carnet.Text = No_carnet;
            txtNombre.Text = Nombre;
            txtCedula.Text = Cedula;
            cbxEstado.Text = Estado;
            cbxTipo_usuario.Text = Tipo_usuario;




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
