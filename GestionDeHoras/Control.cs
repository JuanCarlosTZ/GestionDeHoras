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

    public partial class c_reservaciones : Form
    {
      
        public c_reservaciones()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void btCampus_Click(object sender, EventArgs e)
        {
            FrmCampus campus = new FrmCampus();
            campus.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEmpleados emp = new FrmEmpleados();
            emp.ShowDialog();

        }

        private void c_reservaciones_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUsuario emp = new FrmUsuario();
            emp.ShowDialog();
        }

        private void btnEdificio_Click(object sender, EventArgs e)
        {
            new frmEdificio().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmTanda().Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new FrmEstudiante().ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new FrmProfesor().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FrmTipoAula().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new FrmAula().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new FrmRol().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new FrmPermisoRol().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new FrmUsuarioRol().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            new FrmSolicitudes().Show();
        }

        private void solicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new FrmReportSolicitud().Show();
            VisorReportecs frm = new VisorReportecs();
            frm.ShowDialog();
        }
    }
}
