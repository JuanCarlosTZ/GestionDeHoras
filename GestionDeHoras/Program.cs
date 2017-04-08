using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeHoras
{
    static class Program
    {

        static string acceso;
        static string No_Carnet;

        public static string getAcceso()
        {
            return acceso;
        }
        public static string getNo_Carnet()
        {
            return No_Carnet;
        }
        public static void setAcceso(string pAcceso)
        {
            acceso = pAcceso;
        }

        public static void setNo_Carnet(string pNo_Carnet)
        {
            No_Carnet = pNo_Carnet;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());

            switch (acceso)
            {
                case "ESTUDIANTE":
                    Application.Run(new FrmSolicitudes());
                    break;
                case "EMPLEADO":
                    Application.Run(new c_reservaciones());
                    break;
                case "PROFESOR":
                    Application.Run(new FrmSolicitudes());
                    break;
                default:
                    MessageBox.Show("Acceso denegado");
                    break;
            }
            Application.Run(new c_reservaciones());




        }
        
    }
}
