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
   
    public class ServicioData : DataBase, IServicioData
    {
        public ServicioData(String connectionString)
            : base(connectionString)
        {
        }
        
        public List<Servicio> ListarServicio()
        {
            List<Servicio> listaServicio = new List<Servicio>();

            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_SERVICIO_SEL"))
            {
                using (IDataReader reader = DB.ExecuteReader(command))
                {
                    while (reader.Read())
                    {
                        listaServicio.Add(ServicioDataMap.Get(reader));
                    }
                }
            }

            return listaServicio;
        }

    }
}
