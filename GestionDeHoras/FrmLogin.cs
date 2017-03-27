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
    public partial class FrmLogin : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        DataTable odt;


        public void IniciarSesion()
        {
            string acceso = cbxCriterioAcceso.Text;
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (bd.conectar())
            {
                try
                {
                    string SQL = " Select * from "+acceso +" ";
                    SQL += " where No_Carnet = '" + usuario + "' ";
                    SQL += " and Contrasena = '" + contraseña + "' ";
                    int existe  = bd.ejecutarSQL(SQL).Rows.Count;
                    if (existe > 0 )
                    {
                        Program.setAcceso(acceso);
                        Program.setNo_Carnet(usuario);
                        Close();
                    }else
                    {
                        MessageBox.Show("Incorrecto");
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error");
                }
                
             }
        }
        public void cargarCriterioAcceso()
        {
            if (bd.conectar())
            {
                List<string> criterio = bd.consultar("Tipo_Usuario").Rows.OfType<DataRow>().Select(dr => dr.Field<string>("Nombre")).ToList(); ;
                int i = 0;
                while (i < criterio.Count())
                {
                    cbxCriterioAcceso.Items.Add(criterio.ElementAt(i));
                    i = i + 1;

                }
            }

        }



        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (bd.conectar())
            {
                cargarCriterioAcceso();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }
    }
}
