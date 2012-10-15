using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.CC.Entidades
{
    public class Indicador
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public String Frecuencia { get; set; }
        public String Tipo { get; set; }
        public int Contrato { get; set; }
        public String ValorObjetivo { get; set; }
    }
}
