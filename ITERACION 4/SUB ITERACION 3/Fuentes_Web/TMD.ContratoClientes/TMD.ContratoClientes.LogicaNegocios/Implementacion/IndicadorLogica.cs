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
    public class IndicadorLogica : IIndicadorLogica
    {
        private readonly IIndicadorData _indicadorData;

        public IndicadorLogica()
        {
            _indicadorData = new IndicadorData("");
        }
        
        public List<Indicador> ListarIndicador()
        {
            return _indicadorData.ListarIndicador();
        }
        public void Agregar(Indicador indicador)
        {
            _indicadorData.Agregar(indicador);
        }
        
    }
}
