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
    public partial class FrmSolicitudes : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        DataTable odt = new DataTable();
        Validar vl = new Validar();
        string FrmTipo = "Solicitud";
        string operacion = "N";

        public void consultarMiSolicitud()
        {
            string idUsuario = bd.getIdUsuario();
            if (cbxCriterioMiSolicitud.Text != "" && txtValorMiSolicitud.Text != "")
            {
                odt = bd.consultar(FrmTipo, cbxCriterioMiSolicitud.Text, txtValorMiSolicitud.Text, "ID_Usuario", idUsuario);
            }
            else
            {
                odt = bd.consultar(FrmTipo, "ID_Usuario", idUsuario);
            }
            
            
            dgdMiSolicitud.DataSource = odt;
            dgdMiSolicitud.Refresh();

        }


        public void consultarTodaSolicitud()
        {

            if (cbxCriterioMiSolicitud.Text != "" && txtValorMiSolicitud.Text != "")
            {
                odt = bd.consultar(FrmTipo, cbxCriterioMiSolicitud.Text, txtValorMiSolicitud.Text);
            }
            else
            {
                odt = bd.consultar(FrmTipo);
            }
            dgdMiSolicitud.DataSource = odt;
            dgdMiSolicitud.Refresh();

        }

        public void consultarAula()
        {

            if (cbxCampus.Text != "" && cbxEdificio.Text != "")
            {
                string sql = " select top 1 id from Edificio where nombre  = '" + cbxEdificio.Text + "' ";
                string idCampus = bd.getIdCriterioPorNombre("CAMPUS", "Nombre", cbxCampus.Text);
                string idEdificio = bd.getIdCriterioPorNombre("EDIFICIO","Nombre", cbxEdificio.Text,"ID_Campus", idCampus);
                odt = bd.buscar("Aula", "ID_Edificio", idEdificio);
            }
            else
            {
                odt = bd.consultar("Aula");
            }
            dgdAula.DataSource = odt;
            dgdAula.Refresh();

        }

        public void cargarCriterioMiSolicitud()
        {
            if (bd.conectar())
            {
                List<string> criterio = bd.camposPorTabla(FrmTipo);
                int i = 0;
                while (i < criterio.Count())
                {
                    cbxCriterioMiSolicitud.Items.Add(criterio.ElementAt(i));
                    i = i + 1;

                }
            }

        }

        //public void cargarCriterioSolicitud()
        //{
        //    if (bd.conectar())
        //    {
        //        List<string> criterio = bd.camposPorTabla(FrmTipo);
        //        int i = 0;
        //        while (i < criterio.Count())
        //        {
        //            cbxCriterioSolicitud.Items.Add(criterio.ElementAt(i));
        //            i = i + 1;

        //        }
        //    }

        //}


        public void LimpiarRegistros()
        {
            txtAula.Clear();
            txtID_Aula.Clear();
            txtFechaReservacion.Clear();
            txtComentario.Clear();

        }

        public void agregar()
        {
            if (txtID_Aula.Text != "" && txtFechaReservacion.Text != "" && nudHoras.Text != "")
            {
                string SQLUsuario =  "Select ID_Usuario from " + Program.getAcceso()  + " where No_Carnet = '" +Program.getNo_Carnet() +"' ";
                string idUsuario = bd.ejecutarSQL(SQLUsuario).Rows.OfType<DataRow>().Select(dr => dr.Field<int>("ID_Usuario")).ToList().First().ToString();

                string SQL = " Insert into Solicitud ( ID_Usuario, ID_Aula,Fecha_Reservacion, Cantidad_Hora,Comentario, Estado, Ejecucion) values ( ";
          


                SQL += " '" + idUsuario + "'";
                SQL += ", '" + txtID_Aula.Text + "'";
                SQL += ", '" + txtFechaReservacion.Text + "'";
                SQL += ", '" + nudHoras.Text + "'";
                SQL += ", '" + txtComentario.Text + "'";
                SQL += ", 'ACTIVO'";
                SQL += ", 'ABIERTO'";
                SQL += ")";

                if (bd.insertar(SQL))
                {
                    LimpiarRegistros();
                    tabControlSolicitud.SelectedTab = tabControlSolicitud.TabPages[0];
                    consultarMiSolicitud();
                }

            }
            else
            {
                MessageBox.Show("Faltan campos por completar");
            }
        }

        public void cancelarSolicitud()
        {
            if (bd.conectar())
            {
                DataGridViewRow row = dgdMiSolicitud.CurrentCell.OwningRow;
                string id = row.Cells[0].Value.ToString();
                string SQL = "UPDATE Solicitud ";
                SQL += "set Ejecucion = 'CANCELADO'";
                SQL += ", Estado = 'INACTIVO'";
                SQL += "where id = '"+id+"' ";
                bd.actualizar(SQL);
            }
        }

        public void cargarCampus()
        {
            if (bd.conectar())
            {
                List<string> criterio = bd.consultar("Campus").Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Nombre")).ToList(); ;
                int i = 0;
                cbxCampus.Items.Clear();
                cbxCampus.Text = "";
                cbxCampus.Items.Add("");
                while (i < criterio.Count())
                {
                    cbxCampus.Items.Add(criterio.ElementAt(i));
                    i = i + 1;

                }
            }

        }

        public void cargarEdificio()
        {
            if (bd.conectar())
            {
                string idCampus = bd.getIdCriterioPorNombre("Campus", "Nombre", cbxCampus.Text);
                List<string> criterio = bd.getListaCriterio("EDIFICIO", "ID_Campus", idCampus,"Nombre");
                int i = 0;
                cbxEdificio.Text = "";
                cbxEdificio.Items.Clear();
                cbxEdificio.Items.Add("");
                while (i < criterio.Count())
                {
                    cbxEdificio.Items.Add(criterio.ElementAt(i));
                    i = i + 1;

                }
            }

        }




        public FrmSolicitudes()
        {
            InitializeComponent();
        }

        private void FrmSolicitudes_Load(object sender, EventArgs e)
        {
            if (bd.conectar())
            {
                cargarCriterioMiSolicitud();
                cargarCampus();
                if (bd.getAcceso() == "EMPLEADO")
                {
                    consultarTodaSolicitud();
                    btnCancelar.Visible = true;
                    btnAgregar.Enabled = false;
                }

                consultarMiSolicitud();
                consultarAula();

            }
        }

        private void btnBuscarMiSolicitud_Click(object sender, EventArgs e)
        {
            consultarMiSolicitud();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarRegistros();
            tabControlSolicitud.SelectedTab = tabControlSolicitud.TabPages[1];
        }

        private void cbxCampus_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarEdificio();
            consultarAula();
        }

        private void btnBuscarAula_Click(object sender, EventArgs e)
        {
            //consultarAula();
        }

        private void cbxEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultarAula();
        }

        private void dgdAula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgdAula_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarRegistros();
            DataGridViewRow row = dgdAula.CurrentCell.OwningRow;
            txtID_Aula.Text = row.Cells[0].Value.ToString();
            txtAula.Text = row.Cells[1].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelarSolicitud();
            consultarTodaSolicitud();
        }
    }
}
