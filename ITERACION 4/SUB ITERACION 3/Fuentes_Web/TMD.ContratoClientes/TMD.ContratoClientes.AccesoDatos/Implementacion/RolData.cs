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
   
    public class RolData : DataBase, IRolData
    {
        public RolData(String connectionString)
            : base(connectionString)
        {
        }
        
        public List<Rol> ListarRol()
        {
            List<Rol> listaIndicador = new List<Rol>();

            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_ROL_SEL"))
            {
                using (IDataReader reader = DB.ExecuteReader(command))
                {
                    while (reader.Read())
                    {
                        listaIndicador.Add(RolDataMap.Get(reader));
                    }
                }
            }

            return listaIndicador;
        }
        public void Agregar(Rol rol)
        {
            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_CONTRATO_ROL_INS"))
            {
                DB.AddInParameter(command, "@CODIGO_CONTRATO", DbType.Int32, rol.Contrato);
                DB.AddInParameter(command, "@CODIGO_ROL", DbType.Int32, rol.Id);
                DB.AddInParameter(command, "@NOMBRE", DbType.String, rol.Nombre);
              

                DB.ExecuteNonQuery(command);

            }
        }

    }
}
