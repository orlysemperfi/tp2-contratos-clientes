<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SolicitudContrato.aspx.cs" Inherits="TMD.CC.Site.Vistas.Contrato.SolicitudContrato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style2
        {
            width: 165px;
        }
        .style4
        {
            width: 100%;
        }
        .style5
        {
            width: 592px;
        }
        .style9
        {
            width: 107px;
        }
        .style10
        {
            width: 102px;
        }
        .style11
        {
            width: 59px;
        }
    .style12
    {
        width: 536px;
    }
        .style13
        {
            width: 37px;
        }
        .style16
        {
            width: 315px;
        }
        .style18
        {
            width: 260px;
        }
        .style20
        {
            width: 583px;
        }
        .style21
        {
            width: 89px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<asp:Panel ID="pnlSolicitud" runat="server">
    <div id="actualizarLB" >
    <h1 class="page-title">solicitud de contrato</h1>
        <div class="panel-wrapper">
            <table style="width: 617px;">
                <tr>
                    <td class="style18" valign="top">
                        &nbsp;<label>Tipo de Solicitud:</label></td>
                    <td class="style2">                        
                        <asp:RadioButtonList ID="rbnTipoSolicitud" runat="server" Enabled="False" 
                            RepeatColumns="2" Width="264px">
                            <asp:ListItem Value="R">Requerimiento</asp:ListItem>
                            <asp:ListItem Value="C">Cambio</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td class="style20">
                        <asp:Label ID="labNumeroSolicitud" runat="server" Text="Nro. Solicitud:" 
                            Visible="False"></asp:Label>
                    </td>
                    <td class="style21">
                        
                        <asp:TextBox ID="txtNumeroSolicitud" runat="server" Enabled="False" 
                            ReadOnly="True" Visible="False" Width="112px"></asp:TextBox>
                        
                    </td>
                </tr>
                <tr>
                <td class="style18" valign="top">
                        (*)Descripción:
                        </td>
                <td colspan = "3">
                    <asp:TextBox ID="txtDescripcion" runat="server" Height="50px" 
                        TextMode="MultiLine" Width="479px" MaxLength="300"></asp:TextBox>
                    </td>
                    <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtDescripcion" ErrorMessage="Debe ingresar la descripción">*</asp:RequiredFieldValidator></td>
                </tr>
            </table>
            <table align="left" class="style4">
                <tr>
                    <td class="style5" valign="top">
                        &nbsp;&nbsp;<asp:Panel ID="pnlRequerimiento" runat="server">
                            <table class="style4">
                                <tr>
                                    <td class="style9">
                                        Nro. Buena PRO:</td>
                                    <td>
                                        <asp:TextBox ID="txtNroBuenaPro" runat="server" MaxLength="15"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style9">
                                        Nro. Carta Fianza::</td>
                                    <td>
                                        <asp:TextBox ID="txtNroCartaFianza" runat="server" MaxLength="15"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan ="2"</td>
                                        <asp:Panel ID="Panel1" runat="server" GroupingText="Datos del Cliente" 
                                            Height="326px">
                                            <table class="style4">
                                                <tr>
                                                    <td class="style10">
                                                        (*)Tipo Cliente:</td>
                                                    <td>
                                                        <asp:RadioButtonList ID="rbnTipoCliente" runat="server" Height="31px" 
                                                            RepeatColumns="2" Width="264px">
                                                            <asp:ListItem Value="R">Privado</asp:ListItem>
                                                            <asp:ListItem Value="P">Público</asp:ListItem>
                                                        </asp:RadioButtonList>
                                                    </td>
                                                    <td>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                            ControlToValidate="rbnTipoCliente" ErrorMessage="elecciona un Tipo de Cliente">*</asp:RequiredFieldValidator></td>
                                                </tr>
                                                <tr>
                                                    <td class="style10">
                                                        (*)Razón Social:</td>
                                                    <td>
                                                        <asp:TextBox ID="txtRazonSocial" runat="server" MaxLength="100" Width="326px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                            ControlToValidate="txtRazonSocial" 
                                                            ErrorMessage="Debe ingresar la Razón Social">*</asp:RequiredFieldValidator></td>
                                                </tr>
                                                <tr>
                                                    <td class="style10">
                                                        (*)RUC:</td>
                                                    <td>
                                                        <asp:TextBox ID="txtRuc" runat="server" MaxLength="11"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                            ControlToValidate="txtRuc" ErrorMessage="Debe ingresar el RUC">*</asp:RequiredFieldValidator></td>
                                                </tr>
                                                <tr>
                                                    <td class="style10">
                                                        (*)Dirección:</td>
                                                    <td>
                                                        <asp:TextBox ID="txtDireccion" runat="server" MaxLength="200" Width="325px"></asp:TextBox>

                                                    </td>
                                                    <td>
                                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                            ControlToValidate="txtDireccion" ErrorMessage="Debe ingresar la Dirección">*</asp:RequiredFieldValidator></td>
                                                </tr>
                                                <tr>
                                                    <td class="style10">
                                                        Teléfono:</td>
                                                    <td>
                                                        <asp:TextBox ID="txtTelefono" runat="server" MaxLength="20"></asp:TextBox>
                                                    </td>
                                                    <td></td>
                                                </tr>
                                                <tr>
                                                    <td class="style10">
                                                        Anexo:</td>
                                                    <td>
                                                        <asp:TextBox ID="txtAnexo" runat="server" MaxLength="5" Width="65px"></asp:TextBox>
                                                    </td>
                                                    <td></td>
                                                </tr>
                                                <tr>
                                                    <td class="style10">
                                                        Correo:</td>
                                                    <td>
                                                        <asp:TextBox ID="txtCorreo" runat="server" Width="221px"></asp:TextBox>
                                                    </td>
                                                    <td></td>
                                                </tr>
                                                <tr>
                                                    <td class="style10">
                                                        Fax:</td>
                                                    <td>
                                                        <asp:TextBox ID="txtFax" runat="server" MaxLength="15"></asp:TextBox>
                                                    </td>
                                                    <td></td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                </tr>
                            </table>
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="pnlCambio" runat="server">
                            <asp:Panel ID="Panel2" runat="server" 
    GroupingText="Datos del Contrato">
                                <table class="style4">
                                    <tr>
                                        <td class="style11">
                                            Contrato</td>
                                        <td>
                                            <asp:TextBox ID="txtNroContrato" runat="server" ReadOnly="True" Width="161px" 
                                                Enabled="False"></asp:TextBox>
                                            <asp:Button ID="btnElegirContrato" runat="server" Height="20px" Text="Elegir Contrato" 
                                                Width="100px" CausesValidation="False" onclick="btnElegirContrato_Click" />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                                ControlToValidate="txtNroContrato" 
                                                ErrorMessage="Debe seleccionar un contrato">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </asp:Panel>
                        <br />
                    </td>
                    <td valign="top">
                        <asp:Panel ID="pnlCondicion" runat="server" GroupingText="Condición" 
                            Visible="False">
                            <table class="style4">
                                <tr>
                                    <td>
                                        Estato:
                                </tr>
                                <tr>
                                    <td>
                                        <asp:RadioButtonList ID="rbnEstado" runat="server" Width="104px" 
                                        RepeatColumns="3" Enabled="False">
                                            <asp:ListItem Value="P">Pendiente</asp:ListItem>
                                            <asp:ListItem Value="A">Aprobado</asp:ListItem>
                                            <asp:ListItem Value="R">Rechazado</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Motivo:</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtMotivoRechazo" runat="server" Height="68px" TextMode="MultiLine" 
                                        Width="335px" Enabled="False" ReadOnly="True"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                            ShowMessageBox="True" />
                    </td>
                </tr>
            </table>
        </div>
        
            <table style="height: 14px; width: 902px"><tr><td class="style12"></td><td>
                <asp:Button ID="btnGrabar" runat="server" Text="Grabar" 
                    onclick="btnGrabar_Click" Width="93px" />
&nbsp;
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" 
                    onclick="btnConsultar_Click" CausesValidation="False" Width="97px" />
                &nbsp;
                <asp:Button ID="btnCancelar" runat="server" CausesValidation="False" 
                    onclick="btnCancelar_Click" Text="Cancelar" Width="97px" />
                </td></tr></table>
        <div>
            <asp:GridView ID="grvSolicitudes" runat="server" 
                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                GridLines="None" Width="882px" 
                onpageindexchanging="grvSolicitudes_PageIndexChanging" 
                onselectedindexchanged="grvSolicitudes_SelectedIndexChanged" 
                onselectedindexchanging="grvSolicitudes_SelectedIndexChanging" 
                DataKeyNames="Id,NumeroSolicitud,Descripcion,Estado,MotivoRechazo,CampoAdicional">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id">
                    <ItemStyle Width="30px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="NumeroSolicitud" HeaderText="Nro. Solicitud" />
                    <asp:BoundField DataField="TipoSolicitud" HeaderText="Tipo Solicitud" />
                    <asp:BoundField DataField="DESCRIPCION" HeaderText="Descripción">
                    <ItemStyle Width="400px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="ESTADO" HeaderText="Estado" />
                    <asp:BoundField DataField="MOTIVORECHAZO" HeaderText="Motivo Rechazo" 
                        Visible="False" />
                    <asp:BoundField DataField="CampoAdicional" HeaderText="NroContrato" 
                        Visible="False" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </div><!-- END #form_lineabase -->

        <div id="ECS-master" class="panel-wrapper" style="display: none;">

        </div>


    </div><!-- END #content -->

    </asp:Panel>

    
<asp:Panel ID="pnlContrato" runat="server" Visible="False">
    <table class="style4">
        <tr>
            <td class="style13">
                &nbsp;</td>
            <td class="style16">
                
    <h1 class="page-title">Seleccione Contrato</h1></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style13">
                &nbsp;</td>
            <td class="style16">
                <asp:GridView ID="grvContratos" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" GridLines="None" 
                    onselectedindexchanged="grvContratos_SelectedIndexChanged" 
                    onselectedindexchanging="grvContratos_SelectedIndexChanging" Width="270px">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="Id" HeaderText="Id">
                        <ItemStyle Width="30px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="NumeroSolicitud" HeaderText="Nro. Contrato" />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </td>
            <td valign="top">
                <asp:Button ID="btnCancelarSelContrato" runat="server" CausesValidation="False" 
                    onclick="btnCancelarSelContrato_Click" Text="Cancelar" Width="97px" />
            </td>
        </tr>
        <tr>
            <td class="style13">
                &nbsp;</td>
            <td class="style16">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>


</asp:Panel>
</asp:Content>

