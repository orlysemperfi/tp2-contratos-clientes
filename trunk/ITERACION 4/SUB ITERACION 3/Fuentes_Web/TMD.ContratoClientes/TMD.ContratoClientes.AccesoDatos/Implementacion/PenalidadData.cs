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
   
    public class PenalidadData : DataBase, IPenalidadData
    {
        public PenalidadData(String connectionString)
            : base(connectionString)
        {
        }
        
        public List<Penalidad> ListarPenalidad()
        {
            List<Penalidad> listaPenalidad = new List<Penalidad>();

            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_PENALIDAD_SEL"))
            {
                using (IDataReader reader = DB.ExecuteReader(command))
                {
                    while (reader.Read())
                    {
                        listaPenalidad.Add(PenalidadDataMap.Get(reader));
                    }
                }
            }

            return listaPenalidad;
        }
        public void Agregar(Penalidad penalidad)
        {
            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_CONTRATO_PENALIDAD_INS"))
            {
                DB.AddInParameter(command, "@CODIGO_CONTRATO", DbType.Int32, penalidad.Contrato);
                DB.AddInParameter(command, "@CODIGO_PENALIDAD", DbType.String, penalidad.Id);

                DB.ExecuteNonQuery(command);

            }
        }

    }
}
