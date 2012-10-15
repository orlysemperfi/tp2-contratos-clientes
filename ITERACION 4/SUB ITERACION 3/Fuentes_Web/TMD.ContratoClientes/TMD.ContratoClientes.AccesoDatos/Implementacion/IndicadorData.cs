using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.CC.AccesoDatos.Contrato;
using TMD.CC.AccesoDatos.Core;
using System.Data.Common;
using System.Data;
using TMD.CC.Entidades;
using TMD.CC.AccesoDatos.Map;

namespace TMD.CC.AccesoDatos.Implementacion
{
   
    public class IndicadorData : DataBase, IIndicadorData
    {
        public IndicadorData(String connectionString)
            : base(connectionString)
        {
        }
        
        public List<Indicador> ListarIndicador()
        {
            List<Indicador> listaIndicador = new List<Indicador>();

            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_INDICADOR_SEL"))
            {
                using (IDataReader reader = DB.ExecuteReader(command))
                {
                    while (reader.Read())
                    {
                        listaIndicador.Add(IndicadorDataMap.Get(reader));
                    }
                }
            }

            return listaIndicador;
        }
        public void Agregar(Indicador indicador)
        {
            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_CONTRATO_INDICADOR_INS"))
            {
                DB.AddInParameter(command, "@CODIGO_CONTRATO", DbType.Int32, indicador.Contrato);
                DB.AddInParameter(command, "@CODIGO_INDICADOR", DbType.Int32, indicador.Id);
                DB.AddInParameter(command, "@VALOR_OBJETIVO", DbType.String, indicador.ValorObjetivo);
              

                DB.ExecuteNonQuery(command);

            }
        }

    }
}
