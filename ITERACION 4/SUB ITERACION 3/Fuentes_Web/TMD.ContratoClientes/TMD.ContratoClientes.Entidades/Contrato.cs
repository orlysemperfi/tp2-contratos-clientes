using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.CC.Entidades
{
    public class Contratos
    {
        public int Id { get; set; }
        public String Numero { get; set; }
        public String TipoDocumento { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal MontoNacional { get; set; }
        public decimal MontoExt { get; set; }
        public String Garantia { get; set; }
        public String Bonificacion { get; set; }
        public int IdSolicitud { get; set; }
        public int IdCliente { get; set; }
        public int IdServicio { get; set; }
        public String Moneda { get; set; }
        public int IdContratoP { get; set; }
    }
}
