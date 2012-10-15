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
   
    public class ClausulaData : DataBase, IClausulaData
    {
        public ClausulaData(String connectionString)
            : base(connectionString)
        {
        }
        
        public List<Clausula> ListarClausula()
        {
            List<Clausula> listaClausula = new List<Clausula>();

            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_CLAUSULA_SEL"))
            {
                using (IDataReader reader = DB.ExecuteReader(command))
                {
                    while (reader.Read())
                    {
                        listaClausula.Add(ClausulaDataMap.Get(reader));
                    }
                }
            }

            return listaClausula;
        }

        public void Agregar(Clausula clausula)
        {
            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_CONTRATO_CLAUSULA_INS"))
                {
                    DB.AddInParameter(command, "@CODIGO_CONTRATO", DbType.Int32, clausula.Contrato);
                    DB.AddInParameter(command, "@CODIGO_CLAUSULA", DbType.String, clausula.Id);
                
                DB.ExecuteNonQuery(command);
               
             }
        }

    }
}
