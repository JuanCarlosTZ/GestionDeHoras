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
            SqlConnection oCon = new SqlConnection(@"Data Source=WENDY\SQLEXPRESS;Initial Catalog=DBUNAPEC;Integrated Security=True");
            oCon.Open();
            
            string SQL = " Insert into Campus (Id_Campus, Nombre, Estado, Descripcion) values ( ";
            SQL += "'" + txtIdentificador.Text + "'" + ',';
            SQL += "'" + txtNombre.Text + "'" + ',';
            SQL += "'" + cbxEstado.Text + "'" + ',';
            SQL += "'" + txtDescripcion.Text + "'" ;
            SQL += ")";

            SqlCommand ocdm = new SqlCommand(SQL, oCon);
            ocdm.ExecuteNonQuery();
            MessageBox.Show("Datos Guardados Correctamente");
            this.Close();


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
