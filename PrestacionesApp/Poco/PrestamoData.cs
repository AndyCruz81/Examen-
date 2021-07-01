using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestacionesApp.Enums;


namespace PrestacionesApp.Poco
{
    public class PrestamoData
    {
        public double Monto { get; set; }
        public int Plazo { get; set; }
        public Periodo Periodo { get; set; }
        public decimal Tasa { get; set; }

     
    }
}
