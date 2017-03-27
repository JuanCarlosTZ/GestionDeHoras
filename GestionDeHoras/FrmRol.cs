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
    public partial class FrmRol : Form
    {

            BaseDeDatos bd = new BaseDeDatos();
            DataTable odt = new DataTable();
            Validar vl = new Validar();
            string FrmTipo = "Rol";
            string operacion = "N";


            public void consultarRol()
            {
                

                if (cbxCriterio.Text != "" && txtBuscar.Text != "")
                {
                    odt = bd.consultar(FrmTipo, cbxCriterio.Text, txtBuscar.Text);
                }
                else
                {
                    odt = bd.consultar(FrmTipo);
                }
                dgdRol.DataSource = odt;
                dgdRol.Refresh();

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

                SQL = "update Rol ";
                SQL += " set Nombre =  '" + txtNombre.Text + "',";
                SQL += " Descripcion =  '" + txtDescripcion.Text + "',";
                SQL += " Estado  =  '" + cbxEstado.Text + "' ,";
                SQL += " Fecha_Actualizado  =  '" + DateTime.Now + "', ";
                SQL += " Actualizado_Por  =  '" + "" + "' ";
                SQL += " where ID = '" + txtIdentificador.Text + "'";

                if (bd.actualizar(SQL))
                {
                    LimpiarRegistros();
                    tabControlRol.SelectedTab = tabControlRol.TabPages[0];
                    consultarRol();
                }
            }


            public void agregar()
            {
                if (txtNombre.Text != "" && cbxEstado.Text != "")
                {
                    string SQL = " Insert into Rol ( Nombre, Estado, Descripcion) values ( ";

                    SQL += "'" + txtNombre.Text + "'" + ',';
                    SQL += "'" + cbxEstado.Text + "'" + ',';
                    SQL += "'" + txtDescripcion.Text + "'";
                    SQL += ")";

                    if (bd.insertar(SQL))
                    {
                        LimpiarRegistros();
                        tabControlRol.SelectedTab = tabControlRol.TabPages[0];
                        consultarRol();
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

        public FrmRol()
        {
            InitializeComponent();
        }
        private void FrmRol_Load(object sender, EventArgs e)
        {
            if (bd.conectar())
            {
                CargarEstado();
                cargarCriterio();
                consultarRol();
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarRol();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarRegistros();
            tabControlRol.SelectedTab = tabControlRol.TabPages[1];
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
