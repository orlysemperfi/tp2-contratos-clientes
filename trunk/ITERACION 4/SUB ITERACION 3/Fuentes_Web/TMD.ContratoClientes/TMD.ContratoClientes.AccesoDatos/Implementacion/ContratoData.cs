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
   
    public class ContratoData : DataBase, IContratoData
    {
        public ContratoData(String connectionString)
            : base(connectionString)
        {
        }
        
        public void Agregar(Contratos contrato)
        {
            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_CONTRATO_INS"))
            {
                DB.AddInParameter(command, "@TIPO_DOCUMENTO", DbType.String, contrato.TipoDocumento);
                DB.AddInParameter(command, "@FECHA_INICIO", DbType.DateTime, contrato.FechaIni);
                DB.AddInParameter(command, "@FECHA_FIN", DbType.DateTime, contrato.FechaFin);
                DB.AddInParameter(command, "@TIPO_CAMBIO", DbType.Decimal, contrato.TipoCambio);
                DB.AddInParameter(command, "@MONTO_MONEDA_NACIONAL", DbType.Decimal, contrato.MontoNacional);
                DB.AddInParameter(command, "@MONTO_MONEDA_EXTRANJERA", DbType.Decimal,contrato.MontoExt);
                DB.AddInParameter(command, "@GARANTIA", DbType.String, contrato.Garantia);
                DB.AddInParameter(command, "@BONIFICACION", DbType.String, contrato.Bonificacion);
                DB.AddInParameter(command, "@CODIGO_SOLICITUD", DbType.Int32, contrato.IdSolicitud);
                DB.AddInParameter(command, "@CODIGO_CLIENTE", DbType.Int32, contrato.IdCliente);
                DB.AddInParameter(command, "@CODIGO_SERVICIO", DbType.Int32, contrato.IdServicio);
                DB.AddInParameter(command, "@CODIGO_MONEDA", DbType.String, contrato.Moneda);
                DB.AddInParameter(command, "@CODIGO_CONTRATO", DbType.Int32, contrato.IdContratoP);
                DB.AddOutParameter(command, "@IDCONTRATO", DbType.Int32,10);
                DB.ExecuteNonQuery(command);
                contrato.Id = Convert.ToInt32(DB.GetParameterValue(command, "@IDCONTRATO"));
            }
        }

    }
}
