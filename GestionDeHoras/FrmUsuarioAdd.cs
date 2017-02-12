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
        public FrmUsuarioAdd()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            string SQL = " Insert into Usuario (No_carnet, Nombre, Cedula,Tipo_usuario,Estado) values ( ";
            SQL += "'" + txtNo_carnet.Text + "'" + ',';
            SQL += "'" + txtNombre.Text + "'" + ',';
            SQL += "'" + txtCedula.Text + "'" + ',';
            SQL += "'" + cbxTipo_usuario.Text + "'" + ',';
            SQL += "'" + cbxEstado.Text + "'";
            SQL += ")";
            
            if(bd.insertar(SQL))
            {
                limpiarCampos();
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
    }
}
