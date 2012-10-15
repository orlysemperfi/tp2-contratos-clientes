using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.CC.Entidades
{
    public class Entregable
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public String FechaPactada { get; set; }
        public String Responsable { get; set; }
        public int Contrato { get; set; }
    }
}
