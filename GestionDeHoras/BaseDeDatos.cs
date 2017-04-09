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
        SqlTransaction transaction;


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

        public DataTable consultar(string pFrmTipo, string pCriterioTipo, string pCriterio, string pCriterioTipo2, string pCriterio2)
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

        public string getIdAulaUltima()
        {
            string subSQL = "select max(id) as ID from aula";
            odt = ejecutarSQL(subSQL);
            string idAula = odt.Rows.OfType<DataRow>().Select(dr => dr.Field<int>("ID")).ToList().First().ToString();
            return idAula;
        }


        public string getIdUsuario()
        {
            string ACCESO = Program.getAcceso();
            string No_Carnet = Program.getNo_Carnet();
            string xSQL = " select ID_Usuario from " + ACCESO + " where No_Carnet =  '" + No_Carnet + "' ";
            odt = ejecutarSQL(xSQL);
            string idUsuario = odt.Rows.OfType<DataRow>().Select(dr => dr.Field<int>("ID_Usuario")).ToList().First().ToString();
            return idUsuario;
        }

        public string getAcceso()
        {
            string ACCESO = Program.getAcceso();
            return ACCESO;
        }


        public string getIdCriterioPorNombre(string ptabla, string pCampo, string pValor)
        {
            string sql = " select top 1 id from " + ptabla + " where " + pCampo + "  = '" + pValor + "' ";
            try
            {
                string id = ejecutarSQL(sql).Rows.OfType<DataRow>().Select(dr => dr.Field<int>("id")).ToList().First().ToString();
                return id;
            }catch(Exception e)
            {
                 return "";
            }
            
           
        }

        public string getIdCriterioPorNombre(string ptabla, string pCampo, string pValor, string pCampo2, string pValor2)
        {
            try
            {
                string sql = " select top 1 id from " + ptabla + " where " + pCampo + "  = '" + pValor + "' and " + pCampo2 + " = '"+ pValor2 + "' ";
            string id = ejecutarSQL(sql).Rows.OfType<DataRow>().Select(dr => dr.Field<int>("id")).ToList().First().ToString();
            return id;
                }catch(Exception e)
                    {
                         return "";
            }
}

        public List<string> getListaCriterio(string pTabla, string pCampoFiltro, string pValor, string pCampoRetorno )
        {
            List<string> lista = buscar(pTabla, pCampoFiltro, pValor).Rows.OfType<DataRow>().Select(dr => dr.Field<string>(pCampoRetorno)).ToList();
            return lista;
        }


        public void iniciaTransaction()
        {
            transaction = ocon.BeginTransaction();
        }

        public void guardarTransaction()
        {
            transaction.Commit();
        }

        public void devolverTransaction()
        {
            transaction.Rollback();
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
