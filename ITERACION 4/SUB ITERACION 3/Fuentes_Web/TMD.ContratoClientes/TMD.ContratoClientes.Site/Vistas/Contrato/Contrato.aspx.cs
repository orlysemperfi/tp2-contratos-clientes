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

    public partial class Contrato : System.Web.UI.Page
    {
       // Clausula clausulaC = new Clausula();
       // List<Clausula> listaCC = new List<Clausula>();
        //Session["Clausulas"] = listaCC;

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            if (id.ToString()!="")
                mfMostrarDatos(id);
        }
        private void mfMostrarDatos(int id)
        {
           
            Solicitud _Solicitud = new Solicitud();
            SolicitudLogica solicitud = new SolicitudLogica();

            _Solicitud = solicitud.ObtenerC(id);

            txtNumSol.Text = _Solicitud.NumeroSolicitud;
            txtTipSol.Text = _Solicitud.TipoSolicitud;
            txtDesSol.Text = _Solicitud.Descripcion;
            txtRUC.Text = _Solicitud.RucCliente;
            txtRZ.Text = _Solicitud.RazonSocial;
            txtTipCli.Text = _Solicitud.TipoCliente;

            mfLlenarLista();

        }

        private void mfLlenarLista()
        {
            ServicioLogica servicio = new ServicioLogica();

            ddlLineaServicio.DataSource = servicio.ListarServicio(); 
            ddlLineaServicio.DataValueField = "Id";
            ddlLineaServicio.DataTextField = "Descripcion";
            ddlLineaServicio.DataBind();
        }

        protected void btnClausula_Click(object sender, EventArgs e)
        {
            pnlContrato.Visible = false;
            pnlClausulas.Visible = true;

            ClausulaLogica clausula = new ClausulaLogica();
            grvClausula.DataSource = clausula.ListarClausula();
            grvClausula.DataBind();

        }

        protected void btnAceptarC_Click(object sender, EventArgs e)
        {
            pnlContrato.Visible = true;
            pnlClausulas.Visible = false;
            Clausula clausulaC = new Clausula();

            clausulaC.Id = grvClausula.DataKeys[grvClausula.SelectedIndex].Values[0].ToString();
            clausulaC.DesCorta = grvClausula.DataKeys[grvClausula.SelectedIndex].Values[1].ToString();
            clausulaC.Tipo = grvClausula.DataKeys[grvClausula.SelectedIndex].Values[2].ToString();

            List<Clausula> listaCC = new List<Clausula>();

            if (Session["Clausulas"] == null)
            {
                listaCC.Add(clausulaC);
                HttpContext.Current.Session.Add("Clausulas", listaCC);
            }
            else
            {
                listaCC = (List<Clausula>)HttpContext.Current.Session["Clausulas"];
                listaCC.Add(clausulaC);
                Session["Clausulas"] = listaCC;
            }
            
            grvClausulaC.DataSource = listaCC;
            grvClausulaC.DataBind();

        }

        protected void btnCancelarC_Click(object sender, EventArgs e)
        {
            pnlContrato.Visible = true;
            pnlClausulas.Visible = false;
        }

        protected void btnPenalidades_Click(object sender, EventArgs e)
        {
            pnlContrato.Visible = false;
            pnlPenalidades.Visible = true;

            PenalidadLogica penalidad = new PenalidadLogica();
            grvPenalidades.DataSource = penalidad.ListarPenalidad();
            grvPenalidades.DataBind();
        }

        protected void btnAceptarP_Click(object sender, EventArgs e)
        {
            pnlContrato.Visible = true;
            pnlPenalidades.Visible = false;

            Penalidad penalidadC = new Penalidad();

            penalidadC.Id = grvPenalidades.DataKeys[grvPenalidades.SelectedIndex].Values[0].ToString();
            penalidadC.Descripcion = grvPenalidades.DataKeys[grvPenalidades.SelectedIndex].Values[1].ToString();
            penalidadC.Porcentaje =decimal.Parse(grvPenalidades.DataKeys[grvPenalidades.SelectedIndex].Values[2].ToString());
            penalidadC.Tipo = grvPenalidades.DataKeys[grvPenalidades.SelectedIndex].Values[3].ToString();

            List<Penalidad> listaPC = new List<Penalidad>();

            if (Session["Penalidades"] == null)
            {
                listaPC.Add(penalidadC);
                HttpContext.Current.Session.Add("Penalidades", listaPC);
            }
            else
            {
                listaPC = (List<Penalidad>)HttpContext.Current.Session["Penalidades"];
                listaPC.Add(penalidadC);
                Session["Penalidades"] = listaPC;
            }
            
            grvPenalidadesC.DataSource = listaPC;
            grvPenalidadesC.DataBind();
        }

        protected void btnCancelarP_Click(object sender, EventArgs e)
        {
            pnlContrato.Visible = true;
            pnlPenalidades.Visible = false;
        }

        protected void btnIndicadores_Click(object sender, EventArgs e)
        {
            pnlContrato.Visible = false;
            pnlIndicadores.Visible = true;
            txtVO.Text = "";
            IndicadorLogica indicador = new IndicadorLogica();
            grvIndicadores.DataSource = indicador.ListarIndicador();
            grvIndicadores.DataBind();
        }

        protected void btnAceptarI_Click(object sender, EventArgs e)
        {
            pnlContrato.Visible = true;
            pnlIndicadores.Visible = false;

            Indicador indicadorC = new Indicador();

            indicadorC.Id = int.Parse(grvIndicadores.DataKeys[grvIndicadores.SelectedIndex].Values[0].ToString());
            indicadorC.Descripcion = grvIndicadores.DataKeys[grvIndicadores.SelectedIndex].Values[1].ToString();
            indicadorC.Frecuencia = grvIndicadores.DataKeys[grvIndicadores.SelectedIndex].Values[2].ToString();
            indicadorC.ValorObjetivo = txtVO.Text;

            List<Indicador> listaIC = new List<Indicador>();

            if (Session["Indicadores"] == null)
            {
                listaIC.Add(indicadorC);
                HttpContext.Current.Session.Add("Indicadores", listaIC);
            }
            else
            {
                listaIC = (List<Indicador>)HttpContext.Current.Session["Indicadores"];
                listaIC.Add(indicadorC);
                Session["Indicadores"] = listaIC;
            }
            
            grvIndicadoresC.DataSource = listaIC;
            grvIndicadoresC.DataBind();

        }

        protected void btnCancelarI_Click(object sender, EventArgs e)
        {
            pnlContrato.Visible = true;
            pnlIndicadores.Visible = false;
        }

        protected void btnEntregables_Click(object sender, EventArgs e)
        {
            pnlContrato.Visible = false;
            pnlEntregables.Visible = true;
            txtFechaP.Text = "";
            txtResponsable.Text = "";
            EntregableLogica entregable = new EntregableLogica();
            grvEntregables.DataSource = entregable.ListarEntregable();
            grvEntregables.DataBind();
        }
        protected void btnRoles_Click(object sender, EventArgs e)
        {
            pnlContrato.Visible = false;
            pnlRoles.Visible = true;
            RolLogica rol = new RolLogica();
            grvRoles.DataSource = rol.ListarRol();
            grvRoles.DataBind();
        }

        protected void btnAceptarE_Click(object sender, EventArgs e)
        {
            pnlContrato.Visible = true;
            pnlEntregables.Visible = false;

            Entregable entregableC = new Entregable();

            entregableC.Id = int.Parse(grvEntregables.DataKeys[grvEntregables.SelectedIndex].Values[0].ToString());
            entregableC.Descripcion = grvEntregables.DataKeys[grvEntregables.SelectedIndex].Values[1].ToString();
            entregableC.FechaPactada = txtFechaP.Text;
            entregableC.Responsable = txtResponsable.Text;

            List<Entregable> listaEC = new List<Entregable>();

            if (Session["Entregables"] == null)
            {
                listaEC.Add(entregableC);
                HttpContext.Current.Session.Add("Entregables", listaEC);
            }
            else
            {
                listaEC = (List<Entregable>)HttpContext.Current.Session["Entregables"];
                listaEC.Add(entregableC);
                Session["Entregables"] = listaEC;
            }
            
            grvEntregablesC.DataSource = listaEC;
            grvEntregablesC.DataBind();
        }

        protected void btnCancelarE_Click(object sender, EventArgs e)
        {
            pnlContrato.Visible = true;
            pnlEntregables.Visible = false;
        }
        protected void btnAceptarR_Click(object sender, EventArgs e)
        {
            pnlContrato.Visible = true;
            pnlRoles.Visible = false;

            Rol rolC = new Rol();

            rolC.Id = int.Parse(grvRoles.DataKeys[grvRoles.SelectedIndex].Values[0].ToString());
            rolC.Nombre = grvRoles.DataKeys[grvRoles.SelectedIndex].Values[1].ToString();

            List<Rol> listaRC = new List<Rol>();

            if (Session["Roles"] == null)
            {
                listaRC.Add(rolC);
                HttpContext.Current.Session.Add("Roles", listaRC);
            }
            else
            {
                listaRC = (List<Rol>)HttpContext.Current.Session["Roles"];
                listaRC.Add(rolC);
                Session["Roles"] = listaRC;
            }

            grvRolesC.DataSource = listaRC;
            grvRolesC.DataBind();
        }
        protected void bnCancelarR_Click(object sender, EventArgs e)
        {
            pnlContrato.Visible = true;
            pnlRoles.Visible = false;
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            ContratoLogica clsContratro = new ContratoLogica();
            Contratos contrato = new Contratos();
            String strTD = "";
            strTD = txtTipSol.Text.Substring(0, 1);
            if (strTD == "R")
                strTD = "C";
            else if (strTD == "C")
                strTD = "A";
            contrato.TipoDocumento = strTD;
            DateTime fechaIni = DateTime.Today;
            DateTime fechaFin = DateTime.Today;
            fechaIni = new DateTime(int.Parse(txtFecIni.Text.Substring(6, 4)), int.Parse(txtFecIni.Text.Substring(3, 2)), int.Parse(txtFecIni.Text.Substring(0, 2)), 0, 0, 0);
            fechaFin = new DateTime(int.Parse(txtFecFin.Text.Substring(6, 4)), int.Parse(txtFecFin.Text.Substring(3, 2)), int.Parse(txtFecFin.Text.Substring(0, 2)), 0, 0, 0);
            contrato.FechaIni = fechaIni;
            contrato.FechaFin = fechaFin;
            contrato.TipoCambio = 3;
            contrato.MontoNacional = 100;
            contrato.MontoExt = 300;
            contrato.Garantia = txtGarantias.Text;
            contrato.Bonificacion = txtBonificaciones.Text;
            contrato.IdSolicitud = int.Parse(Request.QueryString["id"]);
            contrato.IdCliente = 1;
            contrato.IdServicio = int.Parse(ddlLineaServicio.SelectedValue.ToString());
            contrato.Moneda = "PEN";
            contrato.IdContratoP = 0;
            clsContratro.Agregar(contrato);
            int IdContrato = contrato.Id;
            HttpContext.Current.Session.Add("idContrato", IdContrato);

            if (Session["Clausulas"] != null)
            {
                List<Clausula> listaCC = new List<Clausula>();
                listaCC = (List<Clausula>)HttpContext.Current.Session["Clausulas"];
                listaCC.ForEach(RegistrarClausulas);
            }
            if (Session["Penalidades"] != null)
            {
                List<Penalidad> listaPC = new List<Penalidad>();
                listaPC = (List<Penalidad>)HttpContext.Current.Session["Penalidades"];
                listaPC.ForEach(RegistrarPenalidades);
            }
            if (Session["Indicadores"] != null)
            {
                List<Indicador> listaIC = new List<Indicador>();
                listaIC = (List<Indicador>)HttpContext.Current.Session["Indicadores"];
                listaIC.ForEach(RegistrarIndicadores);
            }
            if (Session["Entregables"] != null)
            {
                List<Entregable> listaEC = new List<Entregable>();
                listaEC = (List<Entregable>)HttpContext.Current.Session["Entregables"];
                listaEC.ForEach(RegistrarEntregables);
            }
            Response.Redirect("ContratoSolicitudes.aspx");
        }

        void RegistrarClausulas(Clausula clausula)
        { 
             int IdContrato =(int)HttpContext.Current.Session["idContrato"];

              ClausulaLogica clsClasula = new ClausulaLogica();

                clausula.Contrato = IdContrato;
                clsClasula.Agregar(clausula);
           
        }
        void RegistrarPenalidades(Penalidad penalidad)
        {
            int IdContrato = (int)HttpContext.Current.Session["idContrato"];

            PenalidadLogica clsPenalidad = new PenalidadLogica();

            penalidad.Contrato = IdContrato;
            clsPenalidad.Agregar(penalidad);

        }
        void RegistrarIndicadores(Indicador indicador)
        {
            int IdContrato = (int)HttpContext.Current.Session["idContrato"];

            IndicadorLogica clsIndicador = new IndicadorLogica();

            indicador.Contrato = IdContrato;
            clsIndicador.Agregar(indicador);

        }
        void RegistrarEntregables(Entregable entregable)
        {
            int IdContrato = (int)HttpContext.Current.Session["idContrato"];

            EntregableLogica clsEntregable = new EntregableLogica();

            entregable.Contrato = IdContrato;
            clsEntregable.Agregar(entregable);

        }






    }
}