using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.CC.Entidades
{
    public class Penalidad
    {
        public String Id { get; set; }
        public String Descripcion { get; set; }
        public Decimal Porcentaje { get; set; }
        public String Tipo { get; set; }
        public int Contrato { get; set; }
    }
}
