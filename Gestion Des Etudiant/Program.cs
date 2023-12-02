using Gestion_Des_Etudiant.Data;
using Gestion_Des_Etudiant.View.Statistiques;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Des_Etudiant
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //connect the app to db
            Connections c = new Connections();
            // to access the db from every where just call Connections.connection


            Application.Run(new StatistiquesForm());
        }
    }
}
