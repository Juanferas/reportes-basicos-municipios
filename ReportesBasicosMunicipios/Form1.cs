using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesBasicosMunicipios
{
    public partial class Form1 : Form
    {
        private List<Municipio> municipios;
        private string filePath;

        public Form1()
        {
            InitializeComponent();
            municipios = new List<Municipio>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load data to binding source
            municipioBindingSource.DataSource = new List<Municipio>();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ofd.FileName;
                    //Read csv file to datagridview
                    filePath = ofd.FileName;
                    var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                    
                    var csv = new CsvReader(sr, CultureInfo.CurrentCulture);

                    IEnumerable<Municipio> records = csv.GetRecords<Municipio>();

                    municipioBindingSource.DataSource = records;

                    sr.Close();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string codMunicipio = codMun.Text;
            Console.WriteLine(codMunicipio);

            var sr = new StreamReader(new FileStream(filePath, FileMode.Open));
            var csv = new CsvReader(sr, CultureInfo.CurrentCulture);
            IEnumerable<Municipio> records = csv.GetRecords<Municipio>();

            Municipio found = null;

            foreach (Municipio mun in records)
            {
                if (((Municipio)mun).CodigoMun.Equals(codMunicipio))
                {
                    found = mun;
                    break;
                }
            }

            if (found != null)
            {
                munInfo.Text = "Código Departamento: " + found.CodigoDept +
                       "\nCódigo Municipio: " + found.CodigoMun +
                       "\nNombre Departamento: " + found.NombreDept +
                       "\nNombre Municipio: " + found.NombreMun +
                       "\nTipo: " + found.Tipo;
            }
            else
            {
                munInfo.Text = "Código de Municipio no encontrado";
            }
        }
    }
}
