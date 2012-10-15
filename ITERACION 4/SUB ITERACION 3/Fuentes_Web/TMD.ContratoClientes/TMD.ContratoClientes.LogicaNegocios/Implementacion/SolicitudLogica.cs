using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.CC.LogicaNegocios.Contrato;
using TMD.CC.AccesoDatos.Contrato;
using TMD.CC.Entidades;
using TMD.CC.AccesoDatos.Implementacion;

namespace TMD.CC.LogicaNegocios.Implementacion
{
    public class SolicitudLogica : ISolicitudLogica
    {
        private readonly ISolicitudData _solicitudData;

        public SolicitudLogica()//ISolicitudData solicitudData
        {
            _solicitudData = new SolicitudData("");
        }


        /// <summary>
        /// Agrega un registro a la tabla Fase.
        /// </summary>
        /// <param name="fase">Objeto Fase</param>
        public void Agregar(Solicitud solicitud)
        {
            _solicitudData.Agregar(solicitud);
        }

        /// <summary>
        /// Agrega un registro a la tabla Fase.
        /// </summary>
        /// <param name="fase">Objeto Fase</param>
        public void Modificar(Solicitud solicitud)
        {
            _solicitudData.Modificar(solicitud);
        }

        /// <summary>
        /// Agrega un registro a la tabla Fase.
        /// </summary>
        /// <param name="fase">Objeto Fase</param>
        public void Eliminar(int id)
        {
            _solicitudData.Eliminar(id);
        }

        /// <summary>
        /// Obtiene un registro de la tabla Fase por el id.
        /// </summary>
        /// <param name="id">Id de la Fase</param>
        /// <returns>Fase</returns>
        public Solicitud Obtener(int id)
        {
            return _solicitudData.Obtener(id);
        }

        public Solicitud ObtenerC(int id)
        {
            return _solicitudData.ObtenerC(id);
        }

        /// <summary>
        /// Lista todos los registros de la tabla Fase.
        /// </summary>
        /// <returns>Lista Fase</returns>
        public List<Solicitud> ListarXTipo(String TipoSolicitud)
        {
            return _solicitudData.ListarXTipo(TipoSolicitud);
        }
        public List<Solicitud> ListarContratos()
        {
            return _solicitudData.ListarContratos();
        }

        public List<Solicitud> ListarXTipoC(int Codigo, String tipoSolicitud, String razonSocial, String RUC, String fecIni, String fecFin)
        {
            string strFechaIni = "";
            string strFechaFin = "";
            if (fecIni!="" && fecFin!="")
            {
                strFechaIni = fecIni.PadRight(4) + fecIni.Substring(3, 2) + fecIni.PadLeft(2);
                strFechaFin = fecFin.PadRight(4) + fecFin.Substring(3, 2) + fecFin.PadLeft(2);
            }

            return _solicitudData.ListarXTipoC(Codigo, tipoSolicitud, razonSocial, RUC, strFechaIni, strFechaFin);
        }
    }
}
