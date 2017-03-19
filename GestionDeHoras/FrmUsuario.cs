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
    public partial class FrmUsuario : Form
    {
       

        SqlConnection ocon;
        SqlDataAdapter oda;
        DataTable odt;
        Validar vl = new Validar();
        string SQL;
        string criterio;
        BaseDeDatos bd = new BaseDeDatos();
        string FrmTipo = "Usuario";
        string operacion = "N";


        public FrmUsuario()
        {
            InitializeComponent();


        }


        public string VerFrmTipo()
        {
            return FrmTipo;
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


        public void consultarUsuario()
        {

            if (cbxCriterio.Text != "" && txtBuscar.Text != "")
            {
                odt = bd.consultar(FrmTipo, cbxCriterio.Text, txtBuscar.Text);
            }
            else
            {
                odt = bd.consultar(FrmTipo);
            }
            dgdUsuario.DataSource = odt;
            dgdUsuario.Refresh();



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

        public void LimpiarRegistros()
        {
            txtIdentificador.Clear();
            txtNombre.Clear();
            txtCedula.Clear();
            cbxEstado.Text = "";

            if (operacion == "E")
            {
                lbTitulo.Text = "Nuevo";
                operacion = "N";
                btnAgregar.Text = "&Agregar";
                btnLimpiar.Text = "&Limpiar";

            }

        }

        public void actualizar()
        {
            string SQL;

            SQL = "update  Usuario   ";
            SQL += "  set ";
            SQL += " Nombre =  '" + txtNombre.Text + "'";
            SQL += ", Cedula =  '" + txtCedula.Text + "'";
            SQL += ", Estado  =  '" + cbxEstado.Text + "' ";
            SQL += ", Fecha_Actualizado  =  '" + DateTime.Now + "' ";
            SQL += ", Actualizado_Por  =  '' ";
            SQL += " where ID = '" + txtIdentificador.Text + "'";

            if (bd.actualizar(SQL))
            {
                LimpiarRegistros();
                tabControlUsuario.SelectedTab = tabControlUsuario.TabPages[0];
                consultarUsuario();
            }
        }


        public void agregar()
        {
            bool cedulaExistente = bd.buscar(FrmTipo,"Cedula",txtCedula.Text).Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Cedula")).ToList().Contains(txtCedula.Text) ;

            if (txtNombre.Text != "" && cbxEstado.Text != "" && vl.Cedula(txtCedula.Text) && cedulaExistente == false)
            {
                string SQL = " Insert into Usuario ( Nombre, Cedula, Estado, Fecha_Creado, Creado_Por, Fecha_Actualizado, Actualizado_Por) values ( ";

                SQL += "'" + txtNombre.Text + "' " ;
                SQL += ",'" + txtCedula.Text + "' " ;
                SQL += ",'" + cbxEstado.Text + "' ";
                SQL += ",'" + DateTime.Now + "' ";
                SQL += ", '' ";
                SQL += ",'" + DateTime.Now + "'";
                SQL += ", '' ";
                SQL += ")";

                if (bd.insertar(SQL))
                {
                    LimpiarRegistros();
                    tabControlUsuario.SelectedTab = tabControlUsuario.TabPages[0];
                    consultarUsuario();
                }

            }
            else
            {
                if(txtNombre.Text == "" || cbxEstado.Text == "")
                {
                    MessageBox.Show("Faltan campos por completar");
                }
                else if (cedulaExistente)
                {
                    MessageBox.Show("Usuario existente");
                }
                
            }
        }










        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            if (bd.conectar())
            {
                CargarEstado();
                cargarCriterio();
                consultarUsuario();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarRegistros();
            tabControlUsuario.SelectedTab = tabControlUsuario.TabPages[1];
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarUsuario();
            
        }

        private void dgdUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgdUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dgdUsuario.CurrentCell.OwningRow;
            txtIdentificador.Text = row.Cells[0].Value.ToString();
            txtNombre.Text = row.Cells[1].Value.ToString();
            txtCedula.Text = row.Cells[2].Value.ToString();
            cbxEstado.Text = row.Cells[3].Value.ToString();
            lbTitulo.Text = "Editar";
            operacion = "E";
            btnAgregar.Text = "&Actualizar";
            btnLimpiar.Text = "&Cancelar";
            tabControlUsuario.SelectedTab = tabControlUsuario.TabPages[1];

        }

        private void FrmUsuario_Activated(object sender, EventArgs e)
        {
            consultarUsuario();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
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
