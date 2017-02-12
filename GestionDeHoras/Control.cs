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
    }
}
