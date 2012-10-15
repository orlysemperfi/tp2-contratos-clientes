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
    public class ContratoLogica : IContratoLogica
    {
        private readonly IContratoData _contratoData;

        public ContratoLogica()
        {
            _contratoData = new ContratoData("");
        }
        
        public void Agregar(Contratos contrato)
        {
            _contratoData.Agregar(contrato);
        }

        
    }
}
