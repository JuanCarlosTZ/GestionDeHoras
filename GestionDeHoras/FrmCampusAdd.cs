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
        FrmCampus FRMoCon = new FrmCampus();
        private SqlConnection oCon = null;

        public FrmCampusAdd()
        {
            InitializeComponent();
        }

        private void FrmCampusAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnAgragar_Click(object sender, EventArgs e)
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
                
            


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdentificador.ResetText();
            txtNombre.ResetText();
            cbxEstado.ResetText();
            txtDescripcion.ResetText();

        }
    }
}
