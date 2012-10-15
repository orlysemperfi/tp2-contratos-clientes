using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.CC.Entidades
{
    public class Solicitud
    {
        public int Id { get; set; }
        public String NumeroSolicitud { get; set; }
        public String TipoSolicitud { get; set; }
        public String Descripcion { get; set; }
        public String NumeroBuenaPro { get; set; }
        public String NumeroCartaFianza { get; set; }
        public String RazonSocial { get; set; }
        public String RucCliente { get; set; }
        public String DireccionCliente { get; set; }
        public String TelefonoCliente { get; set; }
        public String AnexoCliente { get; set; }
        public String CorreoCliente { get; set; }
        public String FaxCliente { get; set; }
        public String TipoCliente { get; set; }
        public String Estado { get; set; }
        public String MotivoRechazo { get; set; }
        public int IdContrato { get; set; }
        public String NroContrato { get; set; }
        public String CampoAdicional { get; set; }
    }
}
