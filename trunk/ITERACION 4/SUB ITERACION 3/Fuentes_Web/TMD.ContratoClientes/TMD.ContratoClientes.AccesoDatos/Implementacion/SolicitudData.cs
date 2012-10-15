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
    /// <summary>
    ///  Implementa el Acceso a datos de la entidad Solicitud.
    /// </summary>
    public class SolicitudData : DataBase, ISolicitudData
    {
        public SolicitudData(String connectionString)
            : base(connectionString)
        {
        }
        /// <summary>
        /// Agrega un registro a la tabla Solicitud.
        /// </summary>
        /// <param name="solicitud">Objeto Solicitud</param>
        public void Agregar(Solicitud solicitud)
        {
            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_SOLICITUD_INS"))
            {
                DB.AddInParameter(command, "@TIPO_SOLICITUD", DbType.String, solicitud.TipoSolicitud);
                DB.AddInParameter(command, "@DESCRIPCION", DbType.String, solicitud.Descripcion);
                DB.AddInParameter(command, "@NUMERO_BUENA_PRO", DbType.String, solicitud.NumeroBuenaPro);
                DB.AddInParameter(command, "@NUMERO_CARTA_FIANZA", DbType.String, solicitud.NumeroCartaFianza);
                DB.AddInParameter(command, "@RAZON_SOCIAL_CLIENTE", DbType.String, solicitud.RazonSocial);
                DB.AddInParameter(command, "@RUC_CLIENTE", DbType.String, solicitud.RucCliente);
                DB.AddInParameter(command, "@DIRECCION_CLIENTE", DbType.String, solicitud.DireccionCliente);
                DB.AddInParameter(command, "@TELEFONO_CLIENTE", DbType.String, solicitud.TelefonoCliente);
                DB.AddInParameter(command, "@ANEXO_CLIENTE", DbType.String, solicitud.AnexoCliente);
                DB.AddInParameter(command, "@CORREO_CLIENTE", DbType.String, solicitud.CorreoCliente);
                DB.AddInParameter(command, "@FAX_CLIENTE", DbType.String, solicitud.CorreoCliente);
                DB.AddInParameter(command, "@TIPO_CLIENTE", DbType.String, solicitud.TipoCliente);
                DB.AddInParameter(command, "@CODIGO_CONTRATO", DbType.Int32, solicitud.IdContrato);
                DB.AddOutParameter(command, "@NUMERO_SOLICITUD", DbType.String, 10);
                DB.ExecuteNonQuery(command);
                solicitud.NumeroSolicitud = Convert.ToString(DB.GetParameterValue(command, "@NUMERO_SOLICITUD"));
            }
        }

        /// <summary>
        /// Modifica un registro a la tabla Solicitud.
        /// </summary>
        /// <param name="solicitud">Objeto Solicitud</param>
        public void Modificar(Solicitud solicitud)
        {
            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_SOLICITUD_UPD"))
            {
                DB.AddInParameter(command, "@CODIGO_SOLICITUD", DbType.Int32, solicitud.Id);
                DB.AddInParameter(command, "@DESCRIPCION", DbType.String, solicitud.Descripcion);
                DB.AddInParameter(command, "@NUMERO_BUENA_PRO", DbType.String, solicitud.NumeroBuenaPro);
                DB.AddInParameter(command, "@NUMERO_CARTA_FIANZA", DbType.String, solicitud.NumeroCartaFianza);
                DB.AddInParameter(command, "@RAZON_SOCIAL_CLIENTE", DbType.String, solicitud.RazonSocial);
                DB.AddInParameter(command, "@RUC_CLIENTE", DbType.String, solicitud.RucCliente);
                DB.AddInParameter(command, "@DIRECCION_CLIENTE", DbType.String, solicitud.DireccionCliente);
                DB.AddInParameter(command, "@TELEFONO_CLIENTE", DbType.String, solicitud.TelefonoCliente);
                DB.AddInParameter(command, "@ANEXO_CLIENTE", DbType.String, solicitud.AnexoCliente);
                DB.AddInParameter(command, "@CORREO_CLIENTE", DbType.String, solicitud.CorreoCliente);
                DB.AddInParameter(command, "@FAX_CLIENTE", DbType.String, solicitud.CorreoCliente);
                DB.AddInParameter(command, "@TIPO_CLIENTE", DbType.String, solicitud.TipoCliente);
                DB.ExecuteNonQuery(command);
            }
        }

        /// <summary>
        /// Eliminar un registro a la tabla Solicitud.
        /// </summary>
        /// <param name="id">Id de la Solicitud</param>
        public void Eliminar(int id)
        {
            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_SOLICITUD_DEL"))
            {
                DB.AddInParameter(command, "@CODIGO_SOLICITUD", DbType.Int32, id);

                DB.ExecuteNonQuery(command);
            }
        }

        /// <summary>
        /// Obtiene un registro de la tabla Solicitud por el id.
        /// </summary>
        /// <param name="id">Id de la Fase</param>
        /// <returns>Fase</returns>
        public Solicitud Obtener(int id)
        {
            Solicitud solicitud = null;

            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_SOLICITUD_GET"))
            {
                DB.AddInParameter(command, "@CODIGO_SOLICITUD", DbType.Int32, id);
                using (IDataReader reader = DB.ExecuteReader(command))
                {
                    if (reader.Read())
                    {
                        solicitud = SolicitudDataMap.Get(reader);
                    }
                }
            }

            return solicitud;
        }

        public Solicitud ObtenerC(int id)
        {
            Solicitud solicitud = null;

            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_SOLICITUD_SEL_CONTRATO"))
            {
                DB.AddInParameter(command, "@CODIGO_SOLICITUD", DbType.Int32, id);
                using (IDataReader reader = DB.ExecuteReader(command))
                {
                    if (reader.Read())
                    {
                        solicitud = SolicitudDataMap.SelectC(reader);
                    }
                }
            }

            return solicitud;
        }

        /// <summary>
        /// Lista todos los registros de la tabla Solicitud.
        /// </summary>
        /// <returns>Lista Fase</returns
        public List<Solicitud> ListarXTipo(String tipoSolicitud)
        {
            List<Solicitud> listaSolicitud = new List<Solicitud>();

            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_SOLICITUD_SEL"))
            {
                DB.AddInParameter(command, "@TIPO_SOLICITUD", DbType.String, tipoSolicitud);
                using (IDataReader reader = DB.ExecuteReader(command))
                {
                    while (reader.Read())
                    {
                        listaSolicitud.Add(SolicitudDataMap.Select(reader));
                    }
                }
            }

            return listaSolicitud;
        }
        public List<Solicitud> ListarContratos()
        {
            List<Solicitud> listaSolicitud = new List<Solicitud>();

            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_CONTRATOS_ACTIVOS"))
            {
                using (IDataReader reader = DB.ExecuteReader(command))
                {
                    while (reader.Read())
                    {
                        listaSolicitud.Add(SolicitudDataMap.Contrato(reader));
                    }
                }
            }

            return listaSolicitud;
        }

        public List<Solicitud> ListarXTipoC(int Codigo, String tipoSolicitud, String razonSocial, String RUC, String fecIni, String fecFin)
        {
            List<Solicitud> listaSolicitud = new List<Solicitud>();
            using (DbCommand command = DB.GetStoredProcCommand("CC.USP_SOLICITUD_SEL_CONTRATO"))
            {
                DB.AddInParameter(command, "@CODIGO_SOLICITUD", DbType.Int32, Codigo);
                DB.AddInParameter(command, "@TIPO_SOLICITUD", DbType.String, tipoSolicitud);
                DB.AddInParameter(command, "@RAZON_SOCIAL_CLIENTE", DbType.String, razonSocial);
                DB.AddInParameter(command, "@RUC_CLIENTE", DbType.String, RUC);
                DB.AddInParameter(command, "@FECHA_INI", DbType.String, fecIni);
                DB.AddInParameter(command, "@FECHA_FIN", DbType.String, fecFin);
                using (IDataReader reader = DB.ExecuteReader(command))
                {
                    while (reader.Read())
                    {
                        listaSolicitud.Add(SolicitudDataMap.SelectC(reader));
                    }
                }
            }

            return listaSolicitud;
        }

    }
}
