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
    public partial class FrmCampusEdit : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        DataTable odt = new DataTable();
        public string Identificador = "";
        public string Nombre = "";
        public string Descripcion = "";
        public string Estado = "";

        public FrmCampusEdit()
        {
            InitializeComponent();
        }

        private void btnAgragar_Click(object sender, EventArgs e)
        {
            string SQL;

            SQL = "update Campus ";
            SQL += " set Nombre =  '" + txtNombre.Text + "',";
            SQL += " Descripcion =  '" + txtDescripcion.Text + "',";
            SQL += " Estado  =  '" + cbxEstado.Text + "' ";
            SQL += " where Id_Campus = '" + txtIdentificador.Text + "'";

            if (bd.actualizar(SQL))
            {
                this.Close();
            }
        }

        private void FrmCampusEdit_Load(object sender, EventArgs e)
        {
            txtIdentificador.Text = Identificador;
            txtNombre.Text = Nombre;
            txtDescripcion.Text = Descripcion;
            cbxEstado.Text = Estado;
            
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
