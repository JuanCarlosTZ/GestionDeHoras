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
    public partial class FrmUsuarioRol : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        DataTable odt;
        string operacion = "N";


        public void cargarCriterioRol()
        {

            if (bd.conectar())
            {
                List<string> criterio = bd.camposPorTabla("Rol");
                int i = 0;
                while (i < criterio.Count())
                {
                    cbxCriterioRol.Items.Add(criterio.ElementAt(i));
                    i = i + 1;

                }
            }


        }



        public void cargarCriterioUsuario()
        {

            if (bd.conectar())
            {
                List<string> criterio = bd.camposPorTabla("Usuario");
                int i = 0;
                while (i < criterio.Count())
                {
                    cbxCriterioUsuario.Items.Add(criterio.ElementAt(i));
                    i = i + 1;

                }
            }


        }

        public void consultarRol()
        {

            if (cbxCriterioRol.Text != "" && txtBuscarRol.Text != "")
            {
                odt = bd.consultar("Rol", cbxCriterioRol.Text, txtBuscarRol.Text);
            }
            else
            {
                odt = bd.consultar("Rol");
            }
            dgdRol.DataSource = odt;
            dgdRol.Refresh();
        }




        public void consultarUsuarioBuscarMantenimiento()
        {

            if (txtIdentificador.Text != "" && txtRol.Text != "" && (cbxCriterioUsuario.Text == "" || txtValorUsuario.Text == ""))
            {
                DataGridViewRow row = dgdRol.CurrentCell.OwningRow;
                string Identificador = row.Cells[0].Value.ToString();

                odt = bd.consultar("Asignar_Usuario_Rol", "ID_Rol", Identificador);

                string SQL = " select id, nombre, cedula from Usuario where ID not in (''";


                for (int index = 0; index < odt.Rows.Count; index++)
                {
                    SQL += ",'" + odt.Rows[index][2].ToString() + "'";
                }
                SQL += ")";
                odt = bd.ejecutarSQL(SQL);
                dgdUsuarioBuscarMantenimiento.DataSource = odt;
                dgdUsuarioBuscarMantenimiento.Refresh();
            }
            else if (txtIdentificador.Text != "" && txtRol.Text != "" && cbxCriterioUsuario.Text != "" && txtValorUsuario.Text != "")
            {
                DataGridViewRow row = dgdRol.CurrentCell.OwningRow;
                string Identificador = row.Cells[0].Value.ToString();

                odt = bd.consultar("Asignar_Usuario_Rol", "ID_Rol", Identificador);

                string SQL = " select id, nombre, cedula from Usuario where ";

                SQL += cbxCriterioUsuario.Text + " like '%" + txtValorUsuario.Text + "%' ";
                SQL += " and ID not in (''";


                for (int index = 0; index < odt.Rows.Count; index++)
                {
                    SQL += ",'" + odt.Rows[index][2].ToString() + "'";
                }
                SQL += ")";
                odt = bd.ejecutarSQL(SQL);
                dgdUsuarioBuscarMantenimiento.DataSource = odt;
                dgdUsuarioBuscarMantenimiento.Refresh();
            }
            else
            {
                dgdUsuarioBuscarMantenimiento.DataSource = null;
                dgdUsuarioBuscarMantenimiento.Refresh();
            }

        }


        public void consultarUsuarioAgregadoRolConsulta()
        {

            if (bd.conectar())
            {
                try
                {
                    DataGridViewRow row = dgdRol.CurrentCell.OwningRow;
                    string Identificador = row.Cells[0].Value.ToString();


                    odt = bd.consultar("Asignar_Usuario_Rol", "ID_Rol", Identificador);
                    string SQL = " select id, nombre, cedula from Usuario where ID in(''";


                    for (int index = 0; index < odt.Rows.Count; index++)
                    {
                        SQL += ",'" + odt.Rows[index][2].ToString() + "'";
                    }
                    SQL += ")";

                    odt = bd.ejecutarSQL(SQL);

                    dgdUsuarioAgregadoRolConsulta.DataSource = odt;
                    dgdUsuarioAgregadoRolConsulta.Refresh();
                    consultarUsuarioBuscarMantenimiento();




                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message);
                }
            }

        }


        public void consultarUsuarioAgregadoRolMantenimiento()
        {

            if (bd.conectar())
            {
                try
                {
                    DataGridViewRow row = dgdRol.CurrentCell.OwningRow;
                    string Identificador = row.Cells[0].Value.ToString();
                    string Rol = row.Cells[1].Value.ToString();
                    txtIdentificador.Text = Identificador;
                    txtRol.Text = Rol;

                    odt = bd.consultar("Asignar_Usuario_Rol", "ID_Rol", Identificador);

                    string SQL = " select id, nombre, cedula from Usuario where ID in(''";


                    for (int index = 0; index < odt.Rows.Count; index++)
                    {
                        SQL += ",'" + odt.Rows[index][2].ToString() + "'";
                    }
                    SQL += ")";
                    odt = bd.ejecutarSQL(SQL);

                    dgdUsuarioAgregadoRolMantenimiento.DataSource = odt;
                    dgdUsuarioAgregadoRolMantenimiento.Refresh();
                    consultarUsuarioBuscarMantenimiento();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message);
                }
            }

        }










        public FrmUsuarioRol()
        {
            InitializeComponent();
        }

        private void FrmRolUsuario_Load(object sender, EventArgs e)
        {
            if (bd.conectar())
            {
                cargarCriterioRol();
                cargarCriterioUsuario();
                consultarRol();
                consultarUsuarioAgregadoRolConsulta();
                consultarUsuarioBuscarMantenimiento();
            }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            consultarUsuarioBuscarMantenimiento();
        }

        private void btnBuscarRol_Click(object sender, EventArgs e)
        {
            consultarRol();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {

            consultarUsuarioAgregadoRolMantenimiento();
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        private void dgdRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            consultarUsuarioAgregadoRolConsulta();
        }

        private void dgdRol_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnNuevoUsuario.PerformClick();
        }

        private void dgdUsuarioBuscarMantenimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgdUsuarioBuscarMantenimiento_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAgregarUsuarioMantenimiento.PerformClick();
        }

        private void btnEliminarUsuarioMantenimiento_Click(object sender, EventArgs e)
        {
            if (bd.conectar())
            {
                try
                {
                    DataGridViewRow row = dgdUsuarioAgregadoRolMantenimiento.CurrentCell.OwningRow;
                    string ID_Rol = txtIdentificador.Text;
                    string ID_Usuario = row.Cells[0].Value.ToString();

                    string tabla = " Asignar_Usuario_Rol ";
                    string tiltro = " where  ";
                    tiltro += " ID_Rol  = '" + ID_Rol + "'";
                    tiltro += " and  ID_Usuario = '" + ID_Usuario + "'";

                    bd.eliminar(tabla, tiltro);

                    consultarUsuarioAgregadoRolMantenimiento();
                    consultarUsuarioAgregadoRolConsulta();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message);
                }
            }
        }

        private void btnAgregarUsuarioMantenimiento_Click(object sender, EventArgs e)
        {
            if (bd.conectar())
            {
                try
                {
                    DataGridViewRow row = dgdUsuarioBuscarMantenimiento.CurrentCell.OwningRow;
                    string ID_Rol = txtIdentificador.Text;
                    string ID_Usuario = row.Cells[0].Value.ToString();

                    string SQL = " insert into Asignar_Usuario_Rol (ID_Rol, ID_Usuario) ";
                    SQL += " values( '" + ID_Rol + "'";
                    SQL += ", '" + ID_Usuario + "'";
                    SQL += ") ";


                    bd.insertar(SQL);

                    consultarUsuarioAgregadoRolMantenimiento();
                    consultarUsuarioAgregadoRolConsulta();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message);
                }
            }
        }
    }
}
