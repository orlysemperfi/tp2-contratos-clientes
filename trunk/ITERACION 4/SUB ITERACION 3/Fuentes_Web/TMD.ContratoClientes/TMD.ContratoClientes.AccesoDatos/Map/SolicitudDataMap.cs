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
    static class SolicitudDataMap
    {
        /// <summary>
        /// Mapea un IDataReader a una entidad Solicitud.
        /// </summary>
        /// <param name="reader">Interfas IDataReader</param>
        /// <returns>Solicitud</returns>
        //public static Solicitud Get(IDataReader reader)
        //{
        //    return new Solicitud
        //    {
        //        Id = reader.GetInt("CODIGO_SOLICITUD"),
        //        NumeroSolicitud = reader.GetString("NUMERO_SOLICITUD"),
        //        TipoSolicitud = reader.GetString("TIPO_SOLICITUD"),
        //        Descripcion = reader.GetString("DESCRIPCION"),
        //        NumeroBuenaPro = reader.GetString("NUMERO_BUENA_PRO"),
        //        NumeroCartaFianza = reader.GetString("NUMERO_CARTA_FIANZA"),
        //        RazonSocial = reader.GetString("RAZON_SOCIAL_CLIENTE"),
        //        RucCliente = reader.GetString("RUC_CLIENTE"),
        //        DireccionCliente = reader.GetString("DIRECCION_CLIENTE"),
        //        TelefonoCliente = reader.GetString("TELEFONO_CLIENTE"),
        //        AnexoCliente = reader.GetString("ANEXO_CLIENTE"),
        //        CorreoCliente = reader.GetString("CORREO_CLIENTE"),
        //        FaxCliente = reader.GetString("FAX_CLIENTE"),
        //        TipoPersona = reader.GetString("TIPO_PERSONA"),
        //        TipoCliente = reader.GetString("IPO_CLIENTE"),
        //        Estado = reader.GetString("ESTADO"),
        //        MotivoRechazo = reader.GetString("MOTIVO_RECHAZO"),
        //        IdContrato = reader.GetInt("CODIGO_CONTRATO"),
        //        NroContrato = reader.GetString("NUMERO_DOCUMENTO")
        //    };
        //}

        public static Solicitud Get(IDataReader reader)
        {
            return new Solicitud
            {
                NumeroBuenaPro = reader.GetString("NUMERO_BUENA_PRO"),
                NumeroCartaFianza = reader.GetString("NUMERO_CARTA_FIANZA"),
                RazonSocial = reader.GetString("RAZON_SOCIAL_CLIENTE"),
                RucCliente = reader.GetString("RUC_CLIENTE"),
                DireccionCliente = reader.GetString("DIRECCION_CLIENTE"),
                TelefonoCliente = reader.GetString("TELEFONO_CLIENTE"),
                AnexoCliente = reader.GetString("ANEXO_CLIENTE"),
                CorreoCliente = reader.GetString("CORREO_CLIENTE"),
                FaxCliente = reader.GetString("FAX_CLIENTE"),
                TipoCliente = reader.GetString("TIPO_CLIENTE"),
            };
        }

        /// <summary>
        /// Mapea un IDataReader a una entidad Solicitud.
        /// </summary>
        /// <param name="reader">Interfas IDataReader</param>
        /// <returns>Solicitud</returns>
        public static Solicitud Select(IDataReader reader)
        {
            return new Solicitud
            {
                Id = reader.GetInt("CODIGO_SOLICITUD"),
                NumeroSolicitud = reader.GetString("NUMERO_SOLICITUD"),
                TipoSolicitud = reader.GetString("TIPO_SOLICITUD"),
                Descripcion = reader.GetString("DESCRIPCION"),
                CampoAdicional = reader.GetString("DATO_ADICIONAL"),
                MotivoRechazo = reader.GetString("MOTIVO_RECHAZO"),
                Estado = reader.GetString("ESTADO"),
            };
        }

        public static Solicitud SelectC(IDataReader reader)
        {
            return new Solicitud
            {
                Id = reader.GetInt("CODIGO_SOLICITUD"),
                RucCliente = reader.GetString("RUC_CLIENTE"),
                RazonSocial = reader.GetString("RAZON_SOCIAL_CLIENTE"),
                TipoCliente = reader.GetString("TIPO_CLIENTE"),
                TipoSolicitud = reader.GetString("TIPO_SOLICITUD"),
                NumeroSolicitud = reader.GetString("NUMERO_SOLICITUD"),
                CampoAdicional = reader.GetString("TC"),
                Descripcion = reader.GetString("DESCRIPCION"),
             };
        }

        public static Solicitud Contrato(IDataReader reader)
        {
            return new Solicitud
            {
                Id = reader.GetInt("CODIGO_CONTRATO"),
                NumeroSolicitud = reader.GetString("NUMERO_DOCUMENTO"),
            };
        }
    }
}
