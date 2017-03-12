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
    public partial class FrmCampusAdd : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        DataTable odt = new DataTable();
        FrmCampus FRMoCon = new FrmCampus();
        private SqlConnection oCon = null;
        string frmTipo = new FrmCampus().VerFrmTipo();
        Validar vl = new Validar();

        public FrmCampusAdd()
        {
            InitializeComponent();
        }

        private void FrmCampusAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnAgragar_Click(object sender, EventArgs e)
        {
            if (vl.ID(txtIdentificador.Text, "Id_Campus", frmTipo))
            {
                string SQL = " Insert into Campus ( Nombre, Estado, Descripcion) values ( ";

                SQL += "'" + txtNombre.Text + "'" + ',';
                SQL += "'" + cbxEstado.Text + "'" + ',';
                SQL += "'" + txtDescripcion.Text + "'";
                SQL += ")";

                if (bd.insertar(SQL))
                {
                    this.Close();
                }

            }else
            {
                MessageBox.Show("Identificador existente");
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdentificador.ResetText();
            txtNombre.ResetText();
            cbxEstado.ResetText();
            txtDescripcion.ResetText();

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
