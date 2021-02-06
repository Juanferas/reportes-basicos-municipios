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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //openInExplorer("");
            //string path = @"C:\Users\";
            //string args = string.Format("/e, /select, \"{0}\"", path);

            //ProcessStartInfo info = new ProcessStartInfo();
            //info.FileName = "explorer";
            //info.Arguments = args;
            //Process.Start(info);
            

            //OpenFileDialog openFileDialog1 = new OpenFileDialog
            //{
            //    InitialDirectory = @"D:\",
            //    Title = "Browse Text Files",

            //    CheckFileExists = true,
            //    CheckPathExists = true,

            //    DefaultExt = "txt",
            //    Filter = "csv files (*.csv)|*.csv",
            //    FilterIndex = 2,
            //    RestoreDirectory = true,

            //    ReadOnlyChecked = true,
            //    ShowReadOnly = true
            //};

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
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
                    var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                    var csv = new CsvReader(sr, CultureInfo.CurrentCulture);

                    //var users = csv.GetRecords<Municipio>();

                    //foreach (var user in users)
                    //{
                    //    Console.WriteLine(user);
                    //}

                    //record Municipio(string CodidoDept, string CodidoMun, string NombreDept, string NombreMun, string Tipo);
                    //List<Municipio> m = new List<Municipio>();
                    //try
                    //{
                    //    while (csv.Read())
                    //    {
                    //        var record = new Municipio();

                    //        record.CodigoDept = csv.GetField<string>("Código Departamento");
                    //        record.CodigoMun = csv.GetField<string>("Código Municipio");
                    //        record.NombreDept = csv.GetField<string>("Nombre Departamento");
                    //        record.NombreMun = csv.GetField<string>("Nombre Municipio");
                    //        record.Tipo = csv.GetField<string>("Tipo: Municipio / Isla / Área no municipalizada");

                    //        Console.WriteLine(record.CodigoDept);
                    //        m.Add(record);
                    //    }
                    //}
                    //catch (CsvHelper.ReaderException)
                    //{
                    //    Console.WriteLine("F");
                    //}
                    //municipioBindingSource.DataSource = m;

                    municipioBindingSource.DataSource = csv.GetRecords<Municipio>();
                }
            }
        }
    }
}
