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
    public class PenalidadLogica : IPenalidadLogica
    {
        private readonly IPenalidadData _penalidadData;

        public PenalidadLogica()
        {
            _penalidadData = new PenalidadData("");
        }
        
        public List<Penalidad> ListarPenalidad()
        {
            return _penalidadData.ListarPenalidad();
        }
        public void Agregar(Penalidad penalidad)
        {
            _penalidadData.Agregar(penalidad);
        }

        
    }
}
