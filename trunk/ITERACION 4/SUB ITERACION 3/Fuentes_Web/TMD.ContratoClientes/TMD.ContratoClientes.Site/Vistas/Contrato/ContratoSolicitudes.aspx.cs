using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMD.CC.Entidades;
using TMD.CC.LogicaNegocios.Implementacion;

namespace TMD.CC.Site.Vistas.Contrato
{
    public partial class ContratoSolicitudes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            mfListarDatos();
        }

        private void mfListarDatos()
        {
            SolicitudLogica solicitud = new SolicitudLogica();
            grvSolicitudes.DataSource = solicitud.ListarXTipoC(0,ddlTipo.SelectedValue,txtRZ.Text,txtRUC.Text,txtFechaIni.Text, txtFechaFin.Text);
            grvSolicitudes.DataBind();

        }
        protected void grvSolicitudes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }
        protected void grvSolicitudes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }
        protected void grvSolicitudes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strId = f_capturar_contenido(grvSolicitudes, 0);
            int intId;
            bool bolResult;
            bolResult = int.TryParse(strId, out intId);
            if (bolResult == true)
            {
                Session["Clausulas"] = null;
                Session["Penalidades"] = null;
                Session["Indicadores"] = null;
                Session["Entregables"] = null;
                Session["Roles"] = null;
                Response.Redirect("Contrato.aspx?id=" + strId);
            }
        }
       
        public String f_capturar_contenido(GridView grid, int index)
        {
            try
            {
                return grid.DataKeys[grid.SelectedIndex].Values[index].ToString();
            }
            catch
            {
            }
            return "";
        }
      
    }
}