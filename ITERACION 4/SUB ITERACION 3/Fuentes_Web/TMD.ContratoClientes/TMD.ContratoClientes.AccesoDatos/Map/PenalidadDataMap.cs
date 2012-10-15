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
    static class PenalidadDataMap
    {
      
        public static Penalidad Get(IDataReader reader)
        {
            return new Penalidad
            {
                Id = reader.GetString("CODIGO_PENALIDAD"),
                Descripcion = reader.GetString("DESCRIPCION"),
                Porcentaje = reader.GetDecimal("PORCENTAJE"),
                Tipo = reader.GetString("TIPO"),
                Contrato = 0,
            };
        }

    }
}
