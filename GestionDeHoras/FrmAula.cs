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
    public partial class FrmAula : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        DataTable odt = new DataTable();
        Validar vl = new Validar();
        string FrmTipo = "Aula";
        string operacion = "N";


        public void consultarAula()
        {

            if (cbxCriterio.Text != "" && txtBuscar.Text != "")
            {
                odt = bd.consultar(FrmTipo, cbxCriterio.Text, txtBuscar.Text);
            }
            else
            {
                odt = bd.consultar(FrmTipo);
            }
            dgdAula.DataSource = odt;
            dgdAula.Refresh();

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

        public void cargarCriterioEdificio()
        {

            if (bd.conectar())
            {
                List<string> criterioUsuario = bd.camposPorTabla(FrmTipo);
                int i = 0;
                while (i < criterioUsuario.Count())
                {
                    cbxCriterioEdificio.Items.Add(criterioUsuario.ElementAt(i));
                    i = i + 1;

                }
            }


        }


        public void actualizar()
        {
            if (txtNombre.Text != "" && cbxEstado.Text != "" && nudCapacidad.Value >= 0 && cbxTipo.Text != "" && txtID_Edificio.Text != "")
            {
                string SQL;

                SQL = "update Aula ";
                SQL += " set Nombre =  '" + txtNombre.Text + "'";
                SQL += ", Descripcion =  '" + txtDescripcion.Text + "'";
                SQL += ", Tipo  =  '" + cbxTipo.Text + "'";
                SQL += ", ID_Edificio  =  '" + txtID_Edificio.Text + "'";
                SQL += ", Estado  =  '" + cbxEstado.Text + "'";
                SQL += ", Fecha_Actualizado  =  '" + DateTime.Now + "'";
                SQL += ", Actualizado_Por  =  '" + bd.getIdUsuario() + "'";
                SQL += " where ID = '" + txtID_Aula.Text + "'";

                bd.iniciaTransaction();

                if (bd.actualizar(SQL))
                {
                    string idAula = bd.getIdAulaUltima();
                    SQL = " UPDATE DETALLE_AULA (ID_Aula, Capacidad_Reservacion, Cantidad_Reservacion) VALUES ( ";

                    SQL = "update DETALLE_AULA ";
                    SQL += " set Capacidad_Reservacion =  '" + nudCapacidad.Text + "'";
                    SQL += " where ID_Aula = '" + txtID_Aula.Text + "'";

                    if (bd.actualizar(SQL))
                    {
                        LimpiarRegistros();
                        tabControlAula.SelectedTab = tabControlAula.TabPages[0];
                        consultarAula();
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan campos por completar");
            }
        }


        public void agregar()
        {
            if (txtNombre.Text != "" && cbxEstado.Text != "" && nudCapacidad.Value >= 0 && cbxTipo.Text != "" && txtID_Edificio.Text != "")
            {

                

                string creador = bd.getIdUsuario();
                string SQL = " Insert into Aula ( Nombre, Descripcion, Tipo, ID_Edificio, Estado, Fecha_Creado, Creado_Por, Fecha_Actualizado, Actualizado_Por) values ( ";

                SQL += "'" + txtNombre.Text + "'";
                SQL += ",'" + txtDescripcion.Text + "'";
                SQL += ",'" + cbxTipo.Text + "'";
                SQL += ",'" + txtID_Edificio.Text + "'" ;
                SQL += ",'" + cbxEstado.Text + "'";
                SQL += ",'" + DateTime.Now + "'";
                SQL += ",'" + creador + "'";
                SQL += ",'" + DateTime.Now + "'";
                SQL += ",'" + creador + "'";
                SQL += ")";

                bd.iniciaTransaction();
                if (bd.insertar(SQL))
                {
                    string idAula = bd.getIdAulaUltima();
                    SQL = " INSERT INTO DETALLE_AULA (ID_Aula, Capacidad_Reservacion, Cantidad_Reservacion) VALUES ( ";
                    SQL += "'" + idAula + "'";
                    SQL += ",'" + nudCapacidad.Text + "'";
                    SQL += ",'0'";
                    SQL += ")";
                    if (bd.insertar(SQL))
                    {
                        bd.guardarTransaction();

                        LimpiarRegistros();
                        tabControlAula.SelectedTab = tabControlAula.TabPages[0];
                        consultarAula();
                    }
                    else { bd.devolverTransaction(); }
                }
                else { bd.devolverTransaction(); }

            }
            else
            {
                MessageBox.Show("Faltan campos por completar");
            }
        }

        public void LimpiarRegistros()
        {
            txtID_Edificio.Clear();
            txtNombreEdificio.Clear();
            txtID_Aula.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            cbxTipo.Text = "";
            nudCapacidad.Text = "0";
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


        public void CargarTipoAula()
        {
            if (bd.conectar())
            {
                try
                {
                    odt = bd.consultar("Tipo_Aula");
                    List<string> tipoAula = odt.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Nombre")).ToList();
                    int i = 0;
                    while (i < tipoAula.Count())
                    {
                        cbxTipo.Items.Add(tipoAula.ElementAt(i));
                        i = i + 1;

                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error al calgar los tipos de aula. ");
                }

            }

        }

        public void ConsultarEdificio()
        {

            if (cbxCriterioEdificio.Text != "" && txtBuscarEdificio.Text != "")
            {
                odt = bd.consultar("Edificio", cbxCriterioEdificio.Text, txtBuscarEdificio.Text);
            }
            else
            {
                odt = bd.consultar("Edificio");
            }
            dgdEdificio.DataSource = odt;
            dgdEdificio.Refresh();



        }



        public FrmAula()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarAula();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarRegistros();
            tabControlAula.SelectedTab = tabControlAula.TabPages[1];
        }

        private void dgdAula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarRegistros();
            DataGridViewRow row = dgdAula.CurrentCell.OwningRow;
            string idEdificio = row.Cells[4].Value.ToString();
            txtID_Edificio.Text = idEdificio;

            odt = bd.buscar("Edificio", "ID", idEdificio);
            string valorNombreEdificio = odt.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Nombre")).ToList().First();

            txtNombreEdificio.Text = valorNombreEdificio;
            txtID_Aula.Text = row.Cells[0].Value.ToString();
            txtNombre.Text = row.Cells[1].Value.ToString();
            txtDescripcion.Text = row.Cells[2].Value.ToString();
            cbxTipo.Text = row.Cells[3].Value.ToString();
            cbxEstado.Text = row.Cells[5].Value.ToString();
            nudCapacidad.Text = row.Cells[6].Value.ToString();
            lbTitulo.Text = "Editar";
            operacion = "E";
            btnAgregar.Text = "&Actualizar";
            btnLimpiar.Text = "&Cancelar";
            tabControlAula.SelectedTab = tabControlAula.TabPages[1];
        }

        private void FrmAula_Load(object sender, EventArgs e)
        {
            if (bd.conectar())
            {
                CargarEstado();
                cargarCriterio();
                cargarCriterioEdificio();
                consultarAula();
                CargarTipoAula();
                ConsultarEdificio();
            }

        }

        private void dgdEdificio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarRegistros();
            DataGridViewRow row = dgdEdificio.CurrentCell.OwningRow;
            txtID_Edificio.Text = row.Cells[0].Value.ToString();
            txtNombreEdificio.Text = row.Cells[1].Value.ToString();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            ConsultarEdificio();
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
