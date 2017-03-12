using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeHoras
{
    class Validar
    {
        BaseDeDatos bd = new BaseDeDatos();
        DataTable odt = new DataTable();

        public Boolean ID(string pValor, string pCampo, string pFrmTipo)
        {
            odt = bd.buscar(pFrmTipo, pCampo, pValor);
            if(odt.Rows.Count >= 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("ID Inválido");
                return false;
            }
        }


        public Boolean Cedula(string pCedula)
        {
            

                int vnTotal = 0;

                string vcCedula = pCedula.Replace("-", "");

                int pLongCed = vcCedula.Trim().Length;

                int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };



            if (pLongCed < 11 || pLongCed > 11)
            {
                MessageBox.Show("Cédula Inválida");
                return false;
            }



                for (int vDig = 1; vDig <= pLongCed; vDig++)

                {

                    int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];

                if (vCalculo < 10)
                {
                    vnTotal += vCalculo;
                }

                else
                {
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
                }
                }



            if (vnTotal % 10 == 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Cédula Inválida");
                return false;
            }
            
        }







    }
}
