using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EXPRACU1_Lizarraga.Models
{
    public class ClsListas
    {
        public int cantidad { get; set; }
        public double numero { get; set; }
        public List<double> lista1 { get; set; }
        public List<double> lista2 { get; set; }

        public List<double> listarepetidos { get; set; }

    }
}