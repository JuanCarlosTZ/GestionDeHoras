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
    public partial class FrmPermisoRol : Form
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



        public void cargarCriterioModulo()
        {

            if (bd.conectar())
            {
                List<string> criterio = bd.camposPorTabla("Modulo");
                int i = 0;
                while (i < criterio.Count())
                {
                    cbxCriterioModulo.Items.Add(criterio.ElementAt(i));
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




        public void consultarModuloBuscarMantenimiento()
        {

            if ( txtIdentificador.Text != "" && txtRol.Text != "" && (cbxCriterioModulo.Text == "" || txtValorModulo.Text == ""))
            {
                DataGridViewRow row = dgdRol.CurrentCell.OwningRow;
                string Identificador = row.Cells[0].Value.ToString();

                odt = bd.consultar("Asignar_Permiso_Rol", "ID_Rol", Identificador);

                string SQL = " select * from Modulo where ID not in (''";


                for (int index = 0; index < odt.Rows.Count; index++)
                {
                    SQL += ",'" + odt.Rows[index][2].ToString() + "'";
                }
                SQL += ")";
                odt = bd.ejecutarSQL(SQL);
                dgdModuloBuscarMantenimiento.DataSource = odt;
                dgdModuloBuscarMantenimiento.Refresh();
            }
            else if (txtIdentificador.Text != "" && txtRol.Text != "" && cbxCriterioModulo.Text != "" && txtValorModulo.Text != "")
            {
                DataGridViewRow row = dgdRol.CurrentCell.OwningRow;
                string Identificador = row.Cells[0].Value.ToString();

                odt = bd.consultar("Asignar_Permiso_Rol", "ID_Rol", Identificador);

                string SQL = " select * from Modulo where ";

                SQL += cbxCriterioModulo.Text + " like '%"+txtValorModulo.Text+ "%' ";
                SQL += " and ID not in (''";


                for (int index = 0; index < odt.Rows.Count; index++)
                {
                    SQL += ",'" + odt.Rows[index][2].ToString() + "'";
                }
                SQL += ")";
                odt = bd.ejecutarSQL(SQL);
                dgdModuloBuscarMantenimiento.DataSource = odt;
                dgdModuloBuscarMantenimiento.Refresh();
            }
            else
            {
                dgdModuloBuscarMantenimiento.DataSource = null; 
                dgdModuloBuscarMantenimiento.Refresh();
            }

        }


        public void consultarModuloAgregadoRolConsulta()
        {

            if (bd.conectar())
            {
                try
                {
                    DataGridViewRow row = dgdRol.CurrentCell.OwningRow;
                    string Identificador = row.Cells[0].Value.ToString();
                    

                    odt = bd.consultar("Asignar_Permiso_Rol", "ID_Rol", Identificador);
                    string SQL = " select * from Modulo where ID in(''";


                    for (int index = 0; index < odt.Rows.Count; index++)
                    {
                        SQL += ",'"+odt.Rows[index][2].ToString()+"'";
                    }
                    SQL += ")";

                    odt = bd.ejecutarSQL(SQL);

                    dgdModuloAgregadoRolConsulta.DataSource = odt;
                    dgdModuloAgregadoRolConsulta.Refresh();
                    consultarModuloBuscarMantenimiento();




                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message);
                }
            }

        }


        public void consultarModuloAgregadoRolMantenimiento()
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

                    odt = bd.consultar("Asignar_Permiso_Rol", "ID_Rol", Identificador);

                    string SQL = " select * from Modulo where ID in(''";


                    for (int index = 0; index < odt.Rows.Count; index++)
                    {
                        SQL += ",'" + odt.Rows[index][2].ToString() + "'";
                    }
                    SQL += ")";
                    odt = bd.ejecutarSQL(SQL);

                    dgdModuloAgregadoRolMantenimiento.DataSource = odt;
                    dgdModuloAgregadoRolMantenimiento.Refresh();
                    consultarModuloBuscarMantenimiento();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message);
                }
            }

        }









        public FrmPermisoRol()
        {
            InitializeComponent();
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void FrmPermisoRol_Load(object sender, EventArgs e)
        {
            if (bd.conectar())
            {
                cargarCriterioRol();
                cargarCriterioModulo();
                consultarRol();
                consultarModuloAgregadoRolConsulta();
                consultarModuloBuscarMantenimiento();
            }
        }

        private void btnBuscarRol_Click(object sender, EventArgs e)
        {
            consultarRol();
        }

        private void btnNuevoRol_Click(object sender, EventArgs e)
        {

            consultarModuloAgregadoRolMantenimiento();
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bd.conectar())
            {
                try
                {
                    DataGridViewRow row = dgdModuloBuscarMantenimiento.CurrentCell.OwningRow;
                    string ID_Rol = txtIdentificador.Text;
                    string ID_Modulo = row.Cells[0].Value.ToString();

                    string SQL = " insert into Asignar_Permiso_Rol (ID_Rol, ID_Modulo) ";
                    SQL += " values( '" + ID_Rol + "'";
                    SQL += ", '"+ ID_Modulo +"'";
                    SQL += ") ";


                    bd.insertar(SQL);

                    consultarModuloAgregadoRolMantenimiento();                    
                    consultarModuloAgregadoRolConsulta();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message);
                }
            }
        }



        private void btnBuscarModulo_Click(object sender, EventArgs e)
        {
            consultarModuloBuscarMantenimiento();
        }

        private void dgdRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            consultarModuloAgregadoRolConsulta();
        }

        private void dgdRol_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnNuevoRol.PerformClick();
        }

        private void dgdModuloBuscarMantenimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgdModuloBuscarMantenimiento_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgdModuloBuscarMantenimiento_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAgregarModuloMantenimiento.PerformClick();
        }

        private void btnEliminarModuloMantenimiento_Click(object sender, EventArgs e)
        {
            if (bd.conectar())
            {
                try
                {
                    DataGridViewRow row = dgdModuloAgregadoRolMantenimiento.CurrentCell.OwningRow;
                    string ID_Rol = txtIdentificador.Text;
                    string ID_Modulo = row.Cells[0].Value.ToString();

                    string tabla = " Asignar_Permiso_Rol ";
                    string tiltro = " where  ";
                    tiltro += " ID_Rol  = '" + ID_Rol + "'";
                    tiltro += " and  ID_Modulo = '" + ID_Modulo + "'";

                    bd.eliminar(tabla, tiltro);

                    consultarModuloAgregadoRolMantenimiento();
                    consultarModuloAgregadoRolConsulta();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message);
                }
            }
        }
    }
}
