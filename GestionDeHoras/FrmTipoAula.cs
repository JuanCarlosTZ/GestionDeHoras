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
    public partial class FrmTipoAula : Form
    {


        BaseDeDatos bd = new BaseDeDatos();
        DataTable odt = new DataTable();
        Validar vl = new Validar();
        string FrmTipo = "Tipo_Aula";
        string operacion = "N";

        public void consultarTipoAula()
        {

            if (cbxCriterio.Text != "" && txtBuscar.Text != "")
            {
                odt = bd.consultar(FrmTipo, cbxCriterio.Text, txtBuscar.Text);
            }
            else
            {
                odt = bd.consultar(FrmTipo);
            }
            dgdTipoAula.DataSource = odt;
            dgdTipoAula.Refresh();

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

            SQL = "update Tipo_Aula ";
            SQL += " set Nombre =  '" + txtNombre.Text + "'";
            SQL += ", Descripcion =  '" + txtDescripcion.Text + "'";
            SQL += ", Fecha_Actualizado  =  '" + DateTime.Now + "'";
            SQL += ", Actualizado_Por  =  '' ";
            SQL += " where ID = '" + txtIdentificador.Text + "'";

            if (bd.actualizar(SQL))
            {
                LimpiarRegistros();
                tabControlTipoAula.SelectedTab = tabControlTipoAula.TabPages[0];
                consultarTipoAula();
            }
        }


        public void agregar()
        {
            if (txtNombre.Text != "")
            {
                string SQL = " Insert into Tipo_Aula ( Nombre, Descripcion, Fecha_Creado, Creado_Por, Fecha_Actualizado, Actualizado_Por) values ( ";

                SQL += "'" + txtNombre.Text + "'";
                SQL += ",'" + txtDescripcion.Text + "'";
                SQL += ",'" + DateTime.Now + "'";
                SQL += ",''";
                SQL += ",'" + DateTime.Now + "'";
                SQL += ",''";
                SQL += ")";

                if (bd.insertar(SQL))
                {
                    LimpiarRegistros();
                    tabControlTipoAula.SelectedTab = tabControlTipoAula.TabPages[0];
                    consultarTipoAula();
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




        public FrmTipoAula()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarTipoAula();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarRegistros();
            tabControlTipoAula.SelectedTab = tabControlTipoAula.TabPages[1];
        }

        private void dgdTipoAula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgdTipoAula.CurrentCell.OwningRow;
            txtIdentificador.Text = row.Cells[0].Value.ToString();
            txtNombre.Text = row.Cells[1].Value.ToString();
            txtDescripcion.Text = row.Cells[2].Value.ToString();
            lbTitulo.Text = "Editar";
            operacion = "E";
            btnAgregar.Text = "&Actualizar";
            btnLimpiar.Text = "&Cancelar";
            tabControlTipoAula.SelectedTab = tabControlTipoAula.TabPages[1];
        }

        private void FrmTipoAula_Load(object sender, EventArgs e)
        {
            if (bd.conectar())
            {
                cargarCriterio();
                consultarTipoAula();
            }
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarRegistros();
        }
    }
}
