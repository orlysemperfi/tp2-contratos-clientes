using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.CC.Entidades;
using System.Data;
using TMD.CC.AccesoDatos.Util;

namespace TMD.CC.AccesoDatos.Map
{
    /// <summary>
    /// Clase encargada de mapear los datos de la Entidad Solicitud.
    /// </summary>
    static class EntregableDataMap
    {
      
        public static Entregable Get(IDataReader reader)
        {
            return new Entregable
            {
                Id = reader.GetInt("CODIGO_ENTREGABLE"),
                Descripcion = reader.GetString("DESCRIPCION"),
                FechaPactada = "",
                Responsable = "", 
                Contrato = 0,
            };
        }

    }
}
