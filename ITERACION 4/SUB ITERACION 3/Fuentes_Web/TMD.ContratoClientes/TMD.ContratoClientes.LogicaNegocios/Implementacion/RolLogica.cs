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
    public class RolLogica : IRolLogica
    {
        private readonly IRolData _rolData;

        public RolLogica()
        {
            _rolData = new RolData("");
        }
        
        public List<Rol> ListarRol()
        {
            return _rolData.ListarRol();
        }
        public void Agregar(Rol rol)
        {
            _rolData.Agregar(rol);
        }

        
    }
}
