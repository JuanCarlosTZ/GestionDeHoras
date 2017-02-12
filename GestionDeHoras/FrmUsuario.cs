﻿using System;
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
        string SQL;
        string FrmTipo = "Usuario";
        string criterio;
        BaseDeDatos bd = new BaseDeDatos();

        public FrmUsuario()
        {
            InitializeComponent();
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
            if (odt != null)
            {
                dgdUsuario.DataSource = odt;
                dgdUsuario.Refresh();
            }


        }




        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            consultarUsuario();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmUsuarioAdd add = new FrmUsuarioAdd();
            add.ShowDialog();
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
            DataGridViewRow row = this.dgdUsuario.Rows[0];
            FrmUsuarioEdit frm = new FrmUsuarioEdit();
            frm.No_carnet = row.Cells[0].Value.ToString();
            frm.Nombre = row.Cells[3].Value.ToString();
            frm.Cedula = row.Cells[1].Value.ToString();
            frm.Tipo_usuario = row.Cells[2].Value.ToString();
            frm.Estado = row.Cells[4].Value.ToString();
            frm.ShowDialog();
        }

        private void FrmUsuario_Activated(object sender, EventArgs e)
        {
            consultarUsuario();
        }

    }
}
