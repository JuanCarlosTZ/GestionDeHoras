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
            ocon = new SqlConnection("Data Source=JTEJEDA;Initial Catalog=GESTIONDEAULA;Integrated Security=True");
            return ocon;
        }

        public void setOcon(SqlConnection pOcon)
        {
            ocon = pOcon;
        }
        public DataTable consultar(string pFrmTipo, string pCriterioTipo, string pCriterio)
        {
            if (conectar())
            {
                string SQL = " Select * From " + pFrmTipo;
                SQL += " where " + pCriterioTipo + " Like '%" + pCriterio + "%' ";
                SQL += " Order by " + pCriterioTipo;

                return ejecutarSQL(SQL);
            }
            else
            {
                return null;
            }
            
        }

        public DataTable buscar(string pFrmTipo, string pCriterioTipo, string pCriterio)
        {
            if (conectar())
            {
                string SQL = " Select * From " + pFrmTipo;
                SQL += " where " + pCriterioTipo + " = '" + pCriterio + "' ";
                SQL += " Order by " + pCriterioTipo;

                return ejecutarSQL(SQL);
            }
            else
            {
                return null;
            }

        }


        public DataTable ejecutarSQL(string sql)
        {

            if (conectar())
            {
                try
                {
                    oda = new SqlDataAdapter(sql, ocon);
                    odt = new DataTable();
                    oda.Fill(odt);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error");
                    return null;
                }


                return odt;
            }
            else
            {
                return null;
            }
        }


        public List<string> camposPorTabla(string frmTipo)
        {
            if (conectar())
            {
                string SQL = "  SELECT SO.NAME, SC.NAME as campo";
                SQL += "       FROM sys.objects SO INNER JOIN sys.columns SC ";
                SQL += "        ON SO.OBJECT_ID = SC.OBJECT_ID ";
                SQL += "        WHERE SO.TYPE = 'U' and SO.NAME = '" + frmTipo + "'";
                SQL += "        ORDER BY SO.NAME, SC.NAME ";

                odt = ejecutarSQL(SQL);
                return odt.Rows.OfType<DataRow>().Select(dr => dr.Field<string>("campo")).ToList();
            }
            else
            {
                return null;
            }

        }

        public bool actualizar(string pSQL)
        {
            if (conectar())
            {

                try
                {

                    SqlCommand ocdm = new SqlCommand(pSQL, ocon);
                    ocdm.ExecuteNonQuery();
                    MessageBox.Show("Datos actualizados Correctamente");

                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al actualizar los datos");
                    return false;
                }


                return true;
            }
            else
            {
                return false ;
            }
            
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


        public bool eliminar(string tabla, string filtro)
        {
            if (conectar())
            {

                try
                {
                    string pSQL = "Delete " + tabla +" "+ filtro ;
                    SqlCommand ocdm = new SqlCommand(pSQL, ocon);
                    ocdm.ExecuteNonQuery();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al eliminar");
                    return false;
                }



            }
            else
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

           
            return ejecutarSQL(SQL);
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
