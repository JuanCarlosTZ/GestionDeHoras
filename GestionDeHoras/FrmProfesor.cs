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
    public partial class FrmProfesor : Form
    {





        BaseDeDatos bd = new BaseDeDatos();
        DataTable odt;
        string FrmTipo = "Profesor";
        string operacion = "N";




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

        public void CargarTanda()
        {
            if (bd.conectar())
            {
                try
                {
                    odt = bd.consultar("Tanda");
                    List<string> tanda = odt.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Nombre")).ToList();
                    int i = 0;

                    while (i < tanda.Count())
                    {
                        cbxTanda.Items.Add(tanda.ElementAt(i));
                        i = i + 1;

                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error al calgar los estados. ");
                }

            }

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

        public void cargarCriterioUsuario()
        {

            if (bd.conectar())
            {
                List<string> criterioUsuario = bd.camposPorTabla(FrmTipo);
                int i = 0;
                while (i < criterioUsuario.Count())
                {
                    cbxCriterioUsuario.Items.Add(criterioUsuario.ElementAt(i));
                    i = i + 1;

                }
            }


        }


        public void consultarProfesor()
        {

            if (cbxCriterio.Text != "" && txtBuscar.Text != "")
            {
                odt = bd.consultar(FrmTipo, cbxCriterio.Text, txtBuscar.Text);
            }
            else
            {
                odt = bd.consultar(FrmTipo);
            }
            dgdProfesor.DataSource = odt;
            dgdProfesor.Refresh();
        }


        public void LimpiarRegistros()
        {
            txtID_Usuario.Clear();
            txtNombre.Clear();
            txtID_Profesor.Clear();
            txtNo_Carnet.Clear();
            txtContraseña.Text = "";
            cbxTanda.Text = "";
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

            SQL = "update  Profesor   ";
            SQL += "  set ";
            SQL += " ID_Usuario =  '" + txtID_Usuario.Text + "'";
            SQL += ", No_Carnet =  '" + txtNo_Carnet.Text + "'";
            SQL += ", Contrasena  =  '" + txtContraseña.Text + "' ";
            SQL += ", Tanda_Laboral  =  '" + cbxTanda.Text + "' ";
            SQL += ", Estado  =  '" + cbxEstado.Text + "' ";
            SQL += ", Fecha_Actualizado  =  '" + DateTime.Now + "' ";
            SQL += ", Actualizado_Por  =  '' ";
            SQL += " where ID = '" + txtID_Profesor.Text + "'";

            if (bd.actualizar(SQL))
            {
                LimpiarRegistros();
                tabControlProfesor.SelectedTab = tabControlProfesor.TabPages[0];
                consultarProfesor();
            }
        }


        public void agregar()
        {
            bool noCarnetExistente = bd.buscar(FrmTipo, "No_Carnet", txtNo_Carnet.Text).Rows.OfType<DataRow>().Select(dr => dr.Field<string>("No_Carnet")).ToList().Contains(txtNo_Carnet.Text);

            bool idUsuarioExistente = bd.buscar(FrmTipo, "ID_Usuario", txtID_Usuario.Text).Rows.OfType<DataRow>().Select(dr => dr.Field<int>("ID_Usuario")).ToList().Contains(Int32.Parse(txtID_Usuario.Text));

            if (txtID_Usuario.Text != "" && txtNo_Carnet.Text != "" && txtContraseña.Text != "" && cbxTanda.Text != "" && cbxEstado.Text != "" && !idUsuarioExistente && !noCarnetExistente)
            {

                string SQL = " Insert into Profesor (ID_Usuario, No_Carnet, Contrasena,Tanda_Laboral , Estado, Fecha_Creado, Creado_Por, Fecha_Actualizado, Actualizado_Por) values ( ";

                SQL += "'" + txtID_Usuario.Text + "' ";
                SQL += ",'" + txtNo_Carnet.Text + "' ";
                SQL += ",'" + txtContraseña.Text + "' ";
                SQL += ",'" + cbxTanda.Text + "' ";
                SQL += ",'" + cbxEstado.Text + "' ";
                SQL += ",'" + DateTime.Now + "' ";
                SQL += ", '' ";
                SQL += ",'" + DateTime.Now + "'";
                SQL += ", '' ";
                SQL += ")";

                if (bd.insertar(SQL))
                {
                    LimpiarRegistros();
                    tabControlProfesor.SelectedTab = tabControlProfesor.TabPages[0];
                    consultarProfesor();
                }

            }
            else
            {

                if (txtID_Usuario.Text == "" || txtNo_Carnet.Text == "" || txtContraseña.Text == "" || cbxTanda.Text == "" || cbxEstado.Text == "")
                {
                    MessageBox.Show("Faltan campos por completar");
                }
                else if (idUsuarioExistente || noCarnetExistente)
                {
                    MessageBox.Show("Profesor existente");
                }

            }
        }


        public void consultarUsuario()
        {

            if (cbxCriterioUsuario.Text != "" && txtBuscarUsuario.Text != "")
            {
                odt = bd.consultar("Usuario", cbxCriterioUsuario.Text, txtBuscarUsuario.Text);
            }
            else
            {
                odt = bd.consultar("Usuario");
            }
            dgdUsuario.DataSource = odt;
            dgdUsuario.Refresh();



        }














        public FrmProfesor()
        {
            InitializeComponent();
        }

        private void dgdProfesor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgdProfesor.Rows[0];
            txtID_Profesor.Text = row.Cells[0].Value.ToString();
            string idUsuario = row.Cells[1].Value.ToString();
            txtID_Usuario.Text = idUsuario;

            odt = bd.buscar("Usuario", "ID", idUsuario);
            string valorNombre = odt.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Nombre")).ToList().First();

            txtNombre.Text = valorNombre;

            txtNo_Carnet.Text = row.Cells[2].Value.ToString();
            txtContraseña.Text = row.Cells[3].Value.ToString();
            cbxTanda.Text = row.Cells[4].Value.ToString();
            cbxEstado.Text = row.Cells[5].Value.ToString();

            operacion = "E";
            lbTitulo.Text = "Editar";
            btnAgregar.Text = "&Actualizar";
            btnLimpiar.Text = "&Cancelar";

            tabControlProfesor.SelectedTab = tabControlProfesor.TabPages[1];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarProfesor();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarRegistros();
            tabControlProfesor.SelectedTab = tabControlProfesor.TabPages[1];

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

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            consultarUsuario();
        }

        private void dgdUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarRegistros();
            DataGridViewRow row = dgdUsuario.CurrentCell.OwningRow;
            txtID_Usuario.Text = row.Cells[0].Value.ToString();
            txtNombre.Text = row.Cells[1].Value.ToString();
        }

        private void tabPageMantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            if (bd.conectar())
            {
                CargarEstado();
                CargarTanda();
                cargarCriterio();
                consultarProfesor();
                cargarCriterioUsuario();
                consultarUsuario();
            }
        }
    }
}
