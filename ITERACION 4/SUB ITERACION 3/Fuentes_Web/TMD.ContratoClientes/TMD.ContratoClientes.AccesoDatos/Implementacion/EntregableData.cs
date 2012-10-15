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
   
    public class EntregableData : DataBase, IEntregableData
    {
        public EntregableData(String connectionString)
            : base(connectionString)
        {
        }
        
        public List<Entregable> ListarEntregable()
        {
            List<Entregable> listaEntregable = new List<Entregable>();

            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_ENTREGABLE_SEL"))
            {
                using (IDataReader reader = DB.ExecuteReader(command))
                {
                    while (reader.Read())
                    {
                        listaEntregable.Add(EntregableDataMap.Get(reader));
                    }
                }
            }

            return listaEntregable;
        }
        public void Agregar(Entregable entregable)
        {
            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_CONTRATO_ENTREGABLE_INS"))
            {
                DB.AddInParameter(command, "@CODIGO_CONTRATO", DbType.Int32, entregable.Contrato);
                DB.AddInParameter(command, "@CODIGO_ENTREGABLE", DbType.String, entregable.Id);
                DB.AddInParameter(command, "@FECHA_PACTADA", DbType.DateTime, entregable.FechaPactada);
                DB.AddInParameter(command, "@RESPONSABLE", DbType.String, entregable.Responsable);

                DB.ExecuteNonQuery(command);

            }
        }

    }
}
