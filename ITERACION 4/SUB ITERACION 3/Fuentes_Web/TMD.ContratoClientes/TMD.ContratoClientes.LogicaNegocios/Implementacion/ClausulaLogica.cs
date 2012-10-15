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
    public class ClausulaLogica : IClausulaLogica
    {
        private readonly IClausulaData _clausulaData;

        public ClausulaLogica()
        {
            _clausulaData = new ClausulaData("");
        }
        
        public List<Clausula> ListarClausula()
        {
            return _clausulaData.ListarClausula();
        }
        public void Agregar(Clausula clausula)
        {
            _clausulaData.Agregar(clausula);
        }
        
    }
}
