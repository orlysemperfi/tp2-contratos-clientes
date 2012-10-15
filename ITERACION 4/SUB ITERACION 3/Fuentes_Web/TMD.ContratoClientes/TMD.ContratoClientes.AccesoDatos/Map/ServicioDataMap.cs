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
    static class ServicioDataMap
    {
      
        public static Servicio Get(IDataReader reader)
        {
            return new Servicio
            {
                Id = reader.GetInt("CODIGO_SERVICIO"),
                Descripcion = reader.GetString("DESCRIPCION"),
                CodLinea = reader.GetInt("CODIGO_LINEA_SERVICIO"),
                Linea = reader.GetString("LINEA"),
            };
        }

    }
}
