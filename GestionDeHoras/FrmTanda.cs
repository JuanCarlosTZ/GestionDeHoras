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
    public partial class FrmTanda : Form
    {

        BaseDeDatos bd = new BaseDeDatos();
        DataTable odt = new DataTable();
        Validar vl = new Validar();
        string FrmTipo = "Tanda";
        string operacion = "N";

        public void consultarTanda()
        {

            if (cbxCriterio.Text != "" && txtBuscar.Text != "")
            {
                odt = bd.consultar(FrmTipo, cbxCriterio.Text, txtBuscar.Text);
            }
            else
            {
                odt = bd.consultar(FrmTipo);
            }
            dgdTanda.DataSource = odt;
            dgdTanda.Refresh();

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

            SQL = "update Tanda ";
            SQL += " set Nombre =  '" + txtNombre.Text + "'";
            SQL += ", Descripcion =  '" + txtDescripcion.Text + "'";
            SQL += ", Fecha_Actualizado  =  '" + DateTime.Now + "'";
            SQL += ", Actualizado_Por  =  '' ";
            SQL += " where ID = '" + txtIdentificador.Text + "'";

            if (bd.actualizar(SQL))
            {
                LimpiarRegistros();
                tabControlTanda.SelectedTab = tabControlTanda.TabPages[0];
                consultarTanda();
            }
        }


        public void agregar()
        {
            if (txtNombre.Text != "")
            {
                string SQL = " Insert into Tanda ( Nombre, Descripcion, Fecha_Creado, Creado_Por, Fecha_Actualizado, Actualizado_Por) values ( ";

                SQL += "'" + txtNombre.Text + "'" ;
                SQL += ",'" + txtDescripcion.Text + "'";
                SQL += ",'" + DateTime.Now + "'";
                SQL += ",''";
                SQL += ",'" + DateTime.Now + "'";
                SQL += ",''";
                SQL += ")";

                if (bd.insertar(SQL))
                {
                    LimpiarRegistros();
                    tabControlTanda.SelectedTab = tabControlTanda.TabPages[0];
                    consultarTanda();
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

            if (operacion == "E")
            {
                lbTitulo.Text = "Nuevo";
                operacion = "N";
                btnAgregar.Text = "&Agregar";
                btnLimpiar.Text = "&Limpiar";

            }

        }

       

        public FrmTanda()
        {
            InitializeComponent();
        }

        private void FrmTanda_Load(object sender, EventArgs e)
        {
            if (bd.conectar())
            {
                cargarCriterio();
                consultarTanda();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarTanda();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarRegistros();
            tabControlTanda.SelectedTab = tabControlTanda.TabPages[1];
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarRegistros();
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

        private void dgdTanda_CellDobleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgdTanda.CurrentCell.OwningRow;
            txtIdentificador.Text = row.Cells[0].Value.ToString();
            txtNombre.Text = row.Cells[1].Value.ToString();
            txtDescripcion.Text = row.Cells[2].Value.ToString();
            lbTitulo.Text = "Editar";
            operacion = "E";
            btnAgregar.Text = "&Actualizar";
            btnLimpiar.Text = "&Cancelar";
            tabControlTanda.SelectedTab = tabControlTanda.TabPages[1];
        }
    }
}
