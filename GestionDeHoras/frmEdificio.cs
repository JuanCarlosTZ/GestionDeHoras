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
    public partial class frmEdificio : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        DataTable odt = new DataTable();
        Validar vl = new Validar();
        string FrmTipo = "Edificio";
        string operacion = "N";



        public void LimpiarRegistros()
        {
            txtIdentificador.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            cbxId_Campus.Text = "";
            cbxEstado.Text = "";


            if (operacion == "E")
            {
                lbTitulo.Text = "Nuevo";
                operacion = "N";
                btnAgregar.Text = "&Agregar";
                btnLimpiar.Text = "&Limpiar";

            }

        }



        public void consultarEdificio()
        {

            if (cbxCriterio.Text != "" && txtBuscar.Text != "")
            {
                odt = bd.consultar(FrmTipo, cbxCriterio.Text, txtBuscar.Text);
            }
            else
            {
                odt = bd.consultar(FrmTipo);
            }
            dgdEdificio.DataSource = odt;
            dgdEdificio.Refresh();

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


        public void CargarIdCampus()
        {
            if (bd.conectar())
            {
                try
                {
                    odt = bd.consultar("Campus");
                    List<string> IdCampus = odt.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Nombre")).ToList();
                    int i = 0;
                    while (i < IdCampus.Count())
                    {
                        cbxId_Campus.Items.Add(IdCampus.ElementAt(i));
                        i = i + 1;

                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error al calgar los Id campus ");
                }

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

        public void actualizar()
        {
            string SQL;

            SQL = "update Edificio ";
            SQL += " set Nombre =  '" + txtNombre.Text + "'";
            SQL += ", Descripcion =  '" + txtDescripcion.Text + "'";            

            odt = bd.buscar("Campus", "Nombre", cbxId_Campus.Text) ;
            int valorId_Campus = odt.Rows.OfType<DataRow>().Select(dr => dr.Field<int>("ID")).ToList().ElementAt(0);

            SQL += ", ID_Campus  =  '" + valorId_Campus + "'";
            SQL += ", Estado  =  '" + cbxEstado.Text + "'";
            SQL += ", Fecha_Actualizado  =  '"+ DateTime.Now +"' ";
            SQL += ", Actualizado_Por  = '' ";
            SQL += " where ID = '" + txtIdentificador.Text + "'";

            if (bd.actualizar(SQL))
            {
                LimpiarRegistros();
                tabControlEdificio.SelectedTab = tabControlEdificio.TabPages[0];
                consultarEdificio();
            }
        }


        public void agregar()
        {
            if (txtNombre.Text != "" && cbxEstado.Text != "" && cbxId_Campus.Text != "")
            {
                string SQL = " Insert into Edificio ( Nombre, Descripcion, ID_Campus, Estado, Fecha_Creado, Creado_Por, Fecha_Actualizado, Actualizado_Por) values ( ";

                SQL += " '" + txtNombre.Text + "'" ;
                SQL += ", '" + txtDescripcion.Text + "'" ;
                SQL += ", '" +cbxId_Campus.SelectedIndex + "'";
                SQL += ", '" + cbxEstado.Text + "'";
                SQL += ", '" + DateTime.Now + "'";
                SQL += ", ''";
                SQL += ", '" + DateTime.Now + "'";
                SQL += ", '' ";
                SQL += ")";

                if (bd.insertar(SQL))
                {
                    LimpiarRegistros();
                    tabControlEdificio.SelectedTab = tabControlEdificio.TabPages[0];
                    consultarEdificio();
                }

            }
            else
            {
                MessageBox.Show("Faltan campos por completar");
            }
        }





        public frmEdificio()
        {
            InitializeComponent();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarRegistros();
            tabControlEdificio.SelectedTab = tabControlEdificio.TabPages[1];
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (operacion == "E")
            {
                actualizar();
            }
            else
            {
                agregar();
            }
        }

        private void frmEdificio_Load(object sender, EventArgs e)
        {
            if (bd.conectar())
            {
                CargarEstado();
                cargarCriterio();
                consultarEdificio();
                CargarIdCampus();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarEdificio();
        }

        private void dgdCampus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgdEdificio_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgdEdificio.CurrentCell.OwningRow;
            txtIdentificador.Text = row.Cells[0].Value.ToString();
            txtNombre.Text = row.Cells[1].Value.ToString();
            txtDescripcion.Text = row.Cells[2].Value.ToString();
            cbxEstado.Text = row.Cells[4].Value.ToString();

            odt = bd.buscar("Campus", "id", row.Cells[3].Value.ToString());
            string valorId_Campus = odt.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Nombre")).ToList().ElementAt(0);
            cbxId_Campus.Text = valorId_Campus;

            lbTitulo.Text = "Editar";
            operacion = "E";
            btnAgregar.Text = "&Actualizar";
            btnLimpiar.Text = "&Cancelar";
            tabControlEdificio.SelectedTab = tabControlEdificio.TabPages[1];
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarRegistros();
        }
    }
}
