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
    public partial class SolicitudContrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tipo;
            if (!Page.IsPostBack)
            {
                tipo = Request.QueryString["Tipo"];
                if (tipo == "R")
                {
                    pnlRequerimiento.Visible = true;
                    pnlCambio.Visible = false;
                }
                else {
                    pnlRequerimiento.Visible = false;
                    pnlCambio.Visible = true;
                }
                rbnTipoSolicitud.SelectedValue = tipo;
            }
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            Solicitud solicitud = new Solicitud();
            SolicitudLogica solicitudLogica = new SolicitudLogica();

            solicitud.TipoSolicitud=rbnTipoSolicitud.SelectedValue;
            solicitud.Descripcion=txtDescripcion.Text;
            if(rbnTipoSolicitud.SelectedValue == "R")
            {
                solicitud.NumeroBuenaPro = txtNroBuenaPro.Text;
                solicitud.NumeroCartaFianza = txtNroCartaFianza.Text;
                solicitud.RazonSocial = txtRazonSocial.Text;
                solicitud.RucCliente  = txtRuc.Text;
                solicitud.DireccionCliente  = txtDireccion.Text;
                solicitud.TelefonoCliente  = txtTelefono.Text;
                solicitud.AnexoCliente  = txtAnexo.Text;
                solicitud.CorreoCliente  = txtCorreo.Text;
                solicitud.FaxCliente  = txtFax.Text;
	            solicitud.TipoCliente  = rbnTipoCliente.SelectedValue;        
            }
            else
            {
                if (Session["idContrato"]!=null) solicitud.IdContrato = Int32.Parse(Session["idContrato"].ToString());
            }

            if (Session["idSolicitud"] == null)
            {
                solicitudLogica.Agregar(solicitud);
            }
            else
            {
                solicitud.Id = Int32.Parse(Session["idSolicitud"].ToString()); 
                solicitudLogica.Modificar(solicitud);
                Session["idSolicitud"] = null;
                Session["idContrato"] = null;
            }
            mfLimpiarControles();
            mfListarDatos();
            labNumeroSolicitud.Visible = false;
            txtNumeroSolicitud.Visible = false;

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            mfListarDatos();
        }

        protected void grvSolicitudes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //grvSolicitudes.PageIndex = e.NewPageIndex();
            //mfListarDatos

        }

        protected void grvSolicitudes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            //Solicitud solicitud = new Solicitud();
            //SolicitudLogica solicitudLogica = new SolicitudLogica();
            //GridViewRow row = grvSolicitudes.Rows[e.NewSelectedIndex];

            //Session["idSolicitud"] = row.Cells[1].Text;
            //txtNumeroSolicitud.Text =row.Cells[2].Text;
            //txtDescripcion.Text = row.Cells[4].Text;
            //rbnEstado.SelectedValue = row.Cells[5].Text.Substring(0,1);
            //txtMotivoRechazo.Text = row.Cells[6].Text;

            //if (rbnTipoSolicitud.SelectedValue == "R")
            //{
            //    solicitud = solicitudLogica.Obtener(int.Parse(Session["idSolicitud"].ToString()));                
            //    txtNroBuenaPro.Text = solicitud.NumeroBuenaPro;
            //    txtNroCartaFianza.Text = solicitud.NumeroCartaFianza;
            //    txtRazonSocial.Text = solicitud.RazonSocial;
            //    txtRuc.Text = solicitud.RucCliente ;
            //    txtDireccion.Text = solicitud.DireccionCliente;
            //    txtTelefono.Text = solicitud.TelefonoCliente;
            //    txtAnexo.Text = solicitud.AnexoCliente;
            //    txtCorreo.Text = solicitud.CorreoCliente;
            //    txtFax.Text = solicitud.FaxCliente;
            //    rbnTipoPersona.SelectedValue = solicitud.TipoPersona;
            //    rbnTipoCliente.SelectedValue = solicitud.TipoCliente;
            //}
            //else
            //{
            //    txtNroContrato.Text = row.Cells[7].Text;            
            //}
        }

        private void mfListarDatos() 
        {
            SolicitudLogica solicitud = new SolicitudLogica();
            grvSolicitudes.DataSource = solicitud.ListarXTipo(rbnTipoSolicitud.SelectedValue);
            grvSolicitudes.DataBind();
        }
        private void mfLimpiarControles()
        {
            Session["idSolicitud"] = null;
            Session["idCambio"] = null;
            txtNumeroSolicitud.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            rbnEstado.Items[0].Selected = false;
            rbnEstado.Items[1].Selected = false;
            txtMotivoRechazo.Text = string.Empty;
            txtNroBuenaPro.Text = string.Empty;
            txtNroCartaFianza.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            txtRuc.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtAnexo.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtFax.Text = string.Empty;
            rbnTipoCliente.Items[0].Selected = false;
            rbnTipoCliente.Items[1].Selected = false;
            txtNroContrato.Text = string.Empty;
            btnGrabar.Enabled=true;
            if (rbnTipoSolicitud.SelectedValue == "C") btnElegirContrato.Enabled = true;
            pnlCondicion.Visible = false;
            mfDesHabilitar(true);

        }

        protected void grvSolicitudes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Solicitud solicitud = new Solicitud();
            SolicitudLogica solicitudLogica = new SolicitudLogica();

            Session["idSolicitud"] = f_capturar_contenido(grvSolicitudes,0);// row.Cells[1].Text;
            txtNumeroSolicitud.Text =f_capturar_contenido(grvSolicitudes,1);//
            txtDescripcion.Text = f_capturar_contenido(grvSolicitudes,2);//
            rbnEstado.SelectedValue = f_capturar_contenido(grvSolicitudes,3).Substring(0,1);
            txtMotivoRechazo.Text = f_capturar_contenido(grvSolicitudes,4);//

            if (rbnTipoSolicitud.SelectedValue == "R")
            {
                solicitud = solicitudLogica.Obtener(int.Parse(Session["idSolicitud"].ToString()));                
                txtNroBuenaPro.Text = solicitud.NumeroBuenaPro;
                txtNroCartaFianza.Text = solicitud.NumeroCartaFianza;
                txtRazonSocial.Text = solicitud.RazonSocial;
                txtRuc.Text = solicitud.RucCliente ;
                txtDireccion.Text = solicitud.DireccionCliente;
                txtTelefono.Text = solicitud.TelefonoCliente;
                txtAnexo.Text = solicitud.AnexoCliente;
                txtCorreo.Text = solicitud.CorreoCliente;
                txtFax.Text = solicitud.FaxCliente;
	            rbnTipoCliente.SelectedValue = solicitud.TipoCliente;
            }
            else
            {
                txtNroContrato.Text = f_capturar_contenido(grvSolicitudes,5);//           
            }
            if (rbnTipoSolicitud.SelectedValue == "C") btnElegirContrato.Enabled = false;
            btnGrabar.Enabled=(rbnEstado.SelectedValue == "P") ;
            mfDesHabilitar((rbnEstado.SelectedValue == "P"));
            pnlCondicion.Visible = true;
            labNumeroSolicitud.Visible = true;
            txtNumeroSolicitud.Visible = true;
        }


        
        public String f_capturar_contenido(GridView grid, int index)
        {
            try { return grid.DataKeys[grid.SelectedIndex].Values[index].ToString(); 
            }
            catch { 
            }
            return "";
        }

        protected void btnElegirContrato_Click(object sender, EventArgs e)
        {
            pnlContrato.Visible = true;
            pnlSolicitud.Visible = false;

            SolicitudLogica solicitud = new SolicitudLogica();
            grvContratos.DataSource = solicitud.ListarContratos();
            grvContratos.DataBind();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            mfLimpiarControles();
            labNumeroSolicitud.Visible = false;
            txtNumeroSolicitud.Visible = false;
        }

        protected void btnCancelarSelContrato_Click(object sender, EventArgs e)
        {
            pnlContrato.Visible = false;
            pnlSolicitud.Visible = true;
        }

        protected void grvContratos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = grvContratos.Rows[e.NewSelectedIndex];
            Session["idContrato"] = row.Cells[1].Text;
            txtNroContrato.Text = row.Cells[2].Text;
            pnlContrato.Visible = false;
            pnlSolicitud.Visible = true;

        }

        protected void grvContratos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mfDesHabilitar(bool estado)
        {
            
            txtDescripcion.Enabled = estado;
            if(rbnTipoSolicitud.SelectedValue=="R")
            {
                txtNroBuenaPro.Enabled = estado;
                txtNroCartaFianza.Enabled = estado;
                txtRazonSocial.Enabled = estado;
                txtRuc.Enabled = estado;
                txtDireccion.Enabled = estado;
                txtTelefono.Enabled = estado;
                txtAnexo.Enabled = estado;
                txtCorreo.Enabled = estado;
                txtFax.Enabled = estado;
                rbnTipoCliente.Enabled = estado;
                labNumeroSolicitud.Visible=estado;
                txtNumeroSolicitud.Visible = estado;
            }
        }

    }
}