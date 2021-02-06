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
        //private CsvReader csv;
        //private IEnumerable<Municipio> records;

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

                    //        record.CodigoDept = csv.GetField<string>("CodigoDept");
                    //        record.CodigoMun = csv.GetField<string>("CodigoMun");
                    //        record.NombreDept = csv.GetField<string>("NombreDept");
                    //        record.NombreMun = csv.GetField<string>("NombreMun");
                    //        record.Tipo = csv.GetField<string>("Tipo");


                    //        Console.WriteLine(record.CodigoDept);
                    //        municipios.Add(record);
                    //    }
                    //}
                    //catch (CsvHelper.ReaderException)
                    //{

                    //}
                    //municipioBindingSource.DataSource = m;

                    //Console.WriteLine(municipios.Count());

                    IEnumerable<Municipio> records = csv.GetRecords<Municipio>();

                    municipioBindingSource.DataSource = records;

                    //Municipio mun;

                    //foreach (IEnumerable<Municipio> m in csv.GetRecords<Municipio>())
                    //{

                    //}

                    //municipios = csv.GetRecords<Municipio>().ToList<Municipio>();
                    //foreach (var item in records)
                    //{
                    //    municipios.Add(item);
                    //}


                    //Console.WriteLine(municipios.Count);

                    //for (int i = 1; i < 5; i++)
                    //{
                    //    Console.WriteLine(municipios[i]);
                    //}
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
            
            //Console.WriteLine(records.Count());
            foreach (Municipio mun in records)
            {
                if (((Municipio)mun).CodigoMun.Equals(codMunicipio))
                {
                    found = mun;
                    break;
                }
            }
            //Municipio found = null;
            //foreach (Municipio m in municipios)
            //{
            //    if (m.CodigoMun.Equals(codMunicipio))
            //    {
            //        found = m;
            //        break;
            //    }
            //}

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
