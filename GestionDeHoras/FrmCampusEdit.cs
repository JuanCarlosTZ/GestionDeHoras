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
    }
}
