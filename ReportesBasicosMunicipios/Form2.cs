using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Windows.Forms.DataVisualization.Charting;

namespace ReportesBasicosMunicipios
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Chart Title
            pieChart2.Titles.Add("Gráfico de pastel de municipios por departamento");
            //Chart Color
            pieChart2.Palette = ChartColorPalette.Pastel;
        }

        public void LoadChart(List<Municipio> muns)
        {
            List<Municipio> municipios = muns;
            Console.WriteLine(municipios.Count());
            int count = 0;
            int indexChart = 0;
            string currentDept = "";
            for (int i = 0; i < municipios.Count; i++)
            {
                Municipio current = municipios[i];
                if (current != null)
                {
                    if (currentDept.Equals(""))
                    {
                        currentDept = current.NombreDept;
                    }
                    else if (currentDept.Equals(current.NombreDept))
                    {
                        count++;
                        pieChart2.Series["Series1"].Points.RemoveAt(indexChart);
                    }
                    else
                    {
                        currentDept = current.NombreDept;
                        count = 1;
                        indexChart++;
                    }
                    pieChart2.Series["Series1"].Points.AddXY(current.NombreDept, count);
                    pieChart2.Series["Series1"].Points[indexChart].LegendText = current.NombreDept;
                    pieChart2.Series["Series1"].Points[indexChart].Label = "" + count;
                }
            }
        }
    }
}
