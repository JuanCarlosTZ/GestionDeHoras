using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeHoras
{
    class BaseDeDatos
    {
        public SqlConnection ocon { get; set; }
        SqlDataAdapter oda;
        DataTable odt;


        public SqlConnection getOcon()
        {
            ocon = new SqlConnection("Data Source=JTEJEDA;Initial Catalog=DBUNAPEC;Integrated Security=True");
            return ocon;
        }

        public void setOcon(SqlConnection pOcon)
        {
            ocon = pOcon;
        }
        public DataTable consultar(string pFrmTipo, string pCriterioTipo, string pCriterio)
        {
             
            if(!conectar())
            {
                return null;
            }
            

            
            string SQL = " Select * From " + pFrmTipo;
            SQL += " where " + pCriterioTipo + " Like '%" + pCriterio + "%' ";
            SQL += " Order by "+ pCriterioTipo;

            try
            {
                oda = new SqlDataAdapter(SQL, ocon);
                odt = new DataTable();
                oda.Fill(odt);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la consulata");
                return null;
            }
            

            return odt;
            
        }

        public bool actualizar(string pSQL)
        {
            if (conectar())
            {

                try
                {

                    SqlCommand ocdm = new SqlCommand(pSQL, ocon);
                    ocdm.ExecuteNonQuery();
                    MessageBox.Show("Datos Guardados Correctamente");

                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al guardar los datos");
                    return false;
                }



            }
            else
            {
                return false;
            }

            return true;
            
        }

        public bool insertar(string pSQL)
        {
            if(conectar())
            {
                
                try
                {
                    
                    SqlCommand ocdm = new SqlCommand(pSQL, ocon);
                    ocdm.ExecuteNonQuery();
                    MessageBox.Show("Datos Guardados Correctamente");
                   
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al guardar los datos");
                    return false;
                }



            }else
            {
                return false;
            }

            return true;
            
        }

        public DataTable consultar(string pFrmTipo)
        {
            if (!conectar())
            {
                return null;
            }

            string SQL = " Select * From " + pFrmTipo;
            SQL += " Order by 1 ";

            try
            {
                oda = new SqlDataAdapter(SQL, ocon);
                odt = new DataTable();
                oda.Fill(odt);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la consulata");
                return null;
            }


            return odt;
        }

        public bool conectar()
        {
            
            try
            {
                ocon = getOcon();
                ocon.Open();
                this.setOcon(ocon);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al conectarse a la base de datos");
                return false;
            }
            return true;
        }
    }
}
