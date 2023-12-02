using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Gestion_Des_Etudiant.View.Statistiques
{
    public partial class StatistiquesForm : Form
    {
        public StatistiquesForm()
        {
            InitializeComponent();
            fillChart();
        }


        private void fillChart()
        {
     
            chart1.Series["Nombre Etudiant"].Points.AddXY("Indus", "10000");
            chart1.Series["Nombre Etudiant"].Points.AddXY("GIIA", "8000");
            chart1.Series["Nombre Etudiant"].Points.AddXY("GTR", "7000");
            chart1.Series["Nombre Etudiant"].Points.AddXY("CP2", "10000");
            chart1.Series["Nombre Etudiant"].Points.AddXY("CP1", "8500");

            chart1.Titles.Add("Nombre Etudiants Chart");
        }

    }


}
