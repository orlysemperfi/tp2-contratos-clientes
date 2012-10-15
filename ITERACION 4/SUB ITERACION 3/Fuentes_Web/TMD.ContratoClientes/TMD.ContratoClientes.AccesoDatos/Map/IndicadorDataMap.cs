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
    static class IndicadorDataMap
    {
      
        public static Indicador Get(IDataReader reader)
        {
            return new Indicador
            {
                Id = reader.GetInt("CODIGO_INDICADOR"),
                Descripcion = reader.GetString("DESCRIPCION"),
                Frecuencia = reader.GetString("FRECUENCIA"),
                Tipo = reader.GetString("TIPO_INDICADOR"),
                Contrato = 0,
                ValorObjetivo = "",
            };
        }

    }
}
