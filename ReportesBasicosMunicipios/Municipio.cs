using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportesBasicosMunicipios
{

    public class Municipio
    {
        public string CodigoDept { get; set; }
        public string CodigoMun { get; set; }
        public string NombreDept { get; set; }
        public string NombreMun { get; set; }
        public string Tipo { get; set; }

        public Municipio()
        {

        }

        public Municipio(string CodigoDept, string CodigoMun, string NombreDept, string NombreMun, string Tipo)
        {
            this.CodigoDept = CodigoDept;
            this.CodigoDept = CodigoMun;
            this.NombreDept = NombreDept;
            this.NombreDept = NombreMun;
            this.Tipo = Tipo;
        }


        public override string ToString()
        {
            return "Nombre Municipio: " + NombreMun;
        }

    }
}
