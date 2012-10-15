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
    public class EntregableLogica : IEntregableLogica
    {
        private readonly IEntregableData _entregableData;

        public EntregableLogica()
        {
            _entregableData = new EntregableData("");
        }
        
        public List<Entregable> ListarEntregable()
        {
            return _entregableData.ListarEntregable();
        }
        public void Agregar(Entregable entregable)
        {
            _entregableData.Agregar(entregable);
        }
        
    }
}
