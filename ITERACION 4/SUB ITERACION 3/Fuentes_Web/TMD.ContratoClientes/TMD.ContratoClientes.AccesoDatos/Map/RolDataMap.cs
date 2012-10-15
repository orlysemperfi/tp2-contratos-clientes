using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.CC.Entidades;
using System.Data;
using TMD.CC.AccesoDatos.Util;

namespace TMD.CC.AccesoDatos.Map
{

    static class RolDataMap
    {
      
        public static Rol Get(IDataReader reader)
        {
            return new Rol
            {
                Id = reader.GetInt("CODIGO_ROL"),
                Nombre = reader.GetString("NOMBRE"),
                Contrato = 0,
            };
        }

    }
}
