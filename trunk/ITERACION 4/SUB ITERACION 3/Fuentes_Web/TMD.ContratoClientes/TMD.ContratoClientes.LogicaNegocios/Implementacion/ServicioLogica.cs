using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.CC.LogicaNegocios.Contrato;
using TMD.CC.AccesoDatos.Contrato;
using TMD.CC.Entidades;
using TMD.CC.AccesoDatos.Implementacion;

namespace TMD.CC.LogicaNegocios.Implementacion
{
    public class ServicioLogica : IServicioLogica
    {
        private readonly IServicioData _servicioData;

        public ServicioLogica()
        {
            _servicioData = new ServicioData("");
        }
        
        public List<Servicio> ListarServicio()
        {
            return _servicioData.ListarServicio();
        }

        
    }
}
