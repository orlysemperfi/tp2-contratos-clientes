using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.CC.Entidades;
using System.Data;

namespace TMD.CC.AccesoDatos.Contrato
{    /// <summary>
    /// Contrato  del Acceso a datos de la entidad Solicitud.
    /// </summary>
    public interface ISolicitudData
    {
        /// <summary>
        /// Agrega un registro a la tabla Solicitud.
        /// </summary>
        /// <param name="solicitud">Objeto Solicitud</param>
        void Agregar(Solicitud solicitud);

        /// <summary>
        /// Modifica un registro a la tabla Solicitud.
        /// </summary>
        /// <param name="solicitud">Objeto Solicitud</param>
        void Modificar(Solicitud solicitud);

        /// <summary>
        /// Eliminar un registro a la tabla Solicitud.
        /// </summary>
        /// <param name="id">Id de la Solicitud</param>
        void Eliminar(int id);

        /// <summary>
        /// Obtiene un registro de la tabla Solicitud por el id.
        /// </summary>
        /// <param name="id">Id de la Solicitud</param>
        /// <returns>Solicitud</returns>
        Solicitud Obtener(int id);

        Solicitud ObtenerC(int id);

        /// <summary>
        /// Lista todos los registros de la tabla Solicitud.
        /// </summary>
        /// <returns>Lista Fase</returns>
        List<Solicitud> ListarXTipo(String tipoSolicitud);

        List<Solicitud> ListarContratos();

        List<Solicitud> ListarXTipoC(int Codigo, String tipoSolicitud, String razonSocial, String RUC, String fecIni, String fecFin);
    }
}
