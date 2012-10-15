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
    static class ContratoDataMap
    {

        public static Contratos Get(IDataReader reader)
        {
            return new Contratos
            {
                Id = reader.GetInt("CODIGO_CONTRATO"),
                //Tipo = reader.GetString("TIPO_CLAUSULA"),
                //DesCorta = reader.GetString("DESCRIPCION_CORTA"),
                //DesLarga = reader.GetString("DESCRIPCION_LARGA"),
                //Contrato = 0,
            };
        }

    }
}
