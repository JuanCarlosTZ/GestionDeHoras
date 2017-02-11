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
    public partial class Aulas : Form
    {
        public Aulas()
        {
            InitializeComponent();
        }

        private void aulasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aulasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBUNAPECDataSet);

        }

        private void Aulas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBUNAPECDataSet.Aulas' table. You can move, or remove it, as needed.
            this.aulasTableAdapter.Fill(this.dBUNAPECDataSet.Aulas);

        }
    }
}
