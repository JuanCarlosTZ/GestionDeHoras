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
    public partial class FrmCampus : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        DataTable odt = new DataTable();
        Validar vl = new Validar();
        string FrmTipo = "Campus";
        string operacion = "N";
        


        public string VerFrmTipo()
        {
            return FrmTipo;
        }


        public void consultarCampus()
        {

            if (cbxCriterio.Text != "" && txtBuscar.Text != "")
            {
                odt = bd.consultar(FrmTipo, cbxCriterio.Text, txtBuscar.Text);
            }
            else
            {
                odt = bd.consultar(FrmTipo);
            }
            dgdCampus.DataSource = odt;
            dgdCampus.Refresh();

        }


        public void cargarCriterio()
        {
            if (bd.conectar())
            {
                List<string> criterio = bd.camposPorTabla(FrmTipo);
                int i = 0;
                while (i < criterio.Count())
                {
                    cbxCriterio.Items.Add(criterio.ElementAt(i));
                    i = i + 1;

                }
            }

        }

        public void actualizar()
        {
            string SQL;

            SQL = "update Campus ";
            SQL += " set Nombre =  '" + txtNombre.Text + "',";
            SQL += " Descripcion =  '" + txtDescripcion.Text + "',";
            SQL += " Estado  =  '" + cbxEstado.Text + "' ,";
            SQL += " Fecha_Actualizado  =  '" + DateTime.Now + "', ";
            SQL += " Actualizado_Por  =  '" + "" + "' ";
            SQL += " where ID = '" + txtIdentificador.Text + "'";

            if (bd.actualizar(SQL))
            {
                LimpiarRegistros();                
                tabControlCampus.SelectedTab = tabControlCampus.TabPages[0];
                consultarCampus();
            }
        }


        public void agregar()
        {
            if (txtNombre.Text != "" && cbxEstado.Text != "")
            {
                string SQL = " Insert into Campus ( Nombre, Estado, Descripcion) values ( ";

                SQL += "'" + txtNombre.Text + "'" + ',';
                SQL += "'" + cbxEstado.Text + "'" + ',';
                SQL += "'" + txtDescripcion.Text + "'";
                SQL += ")";

                if (bd.insertar(SQL))
                {
                    LimpiarRegistros();
                    tabControlCampus.SelectedTab = tabControlCampus.TabPages[0];
                    consultarCampus();
                }

            }
            else
            {
                MessageBox.Show("Faltan campos por completar");
            }
        }

        public void LimpiarRegistros()
        {
            txtIdentificador.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            cbxEstado.Text = "";

            if (operacion == "E")
            {
                lbTitulo.Text = "Nuevo";
                operacion = "N";
                btnAgregar.Text = "&Agregar";
                btnLimpiar.Text = "&Limpiar";

            }

        }

        public void CargarEstado()
        {
            if (bd.conectar())
            {
                try
                {
                    odt = bd.consultar("Estado");
                    List<string> estado = odt.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Nombre")).ToList();
                    int i = 0;
                    cbxEstado.Items.Add("");
                    while (i < estado.Count())
                    {
                        cbxEstado.Items.Add(estado.ElementAt(i));
                        i = i + 1;

                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error al calgar los estados. ");
                }

            }

        }





        public FrmCampus()
        {
            InitializeComponent();
        }

    

        private void campusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.campusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBUNAPECDataSet1);

        }

        private void FrmCampus_Load(object sender, EventArgs e)
        {
            if (bd.conectar())
            {
                CargarEstado();
                cargarCriterio();
                consultarCampus();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarRegistros();
            tabControlCampus.SelectedTab = tabControlCampus.TabPages[1];
        }

        private void FrmCampus_Activated(object sender, EventArgs e)
        {
            consultarCampus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarCampus();
        }

        private void dgdCampus_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            DataGridViewRow row = dgdCampus.CurrentCell.OwningRow;
            txtIdentificador.Text = row.Cells[0].Value.ToString();
            txtNombre.Text = row.Cells[1].Value.ToString();
            txtDescripcion.Text = row.Cells[2].Value.ToString();
            cbxEstado.Text = row.Cells[3].Value.ToString();
            lbTitulo.Text = "Editar";
            operacion = "E";
            btnAgregar.Text = "&Actualizar";
            btnLimpiar.Text = "&Cancelar";
            tabControlCampus.SelectedTab = tabControlCampus.TabPages[1];
            
        }



        private void btnAgragar_Click(object sender, EventArgs e)
        {
            if(operacion == "E")
            {
                actualizar();
            }
            else
            {
                agregar();
            }

        }
        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            LimpiarRegistros();

        }

        private void tabPageMantenimiento_Click(object sender, EventArgs e)
        {

        }
    }
}
