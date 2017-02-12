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
        public string No_carnet = "";
        public string Nombre = "";
        public string Cedula = "";
        public string Tipo_usuario = "";
        public string Estado = "";
        public FrmUsuarioEdit()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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

        private void FrmUsuarioEdit_Load(object sender, EventArgs e)
        {

            txtNo_carnet.Text = No_carnet;
            txtNombre.Text = Nombre;
            txtCedula.Text = Cedula;
            cbxEstado.Text = Estado;
            cbxTipo_usuario.Text = Tipo_usuario;
            
           
        }
    }
}
