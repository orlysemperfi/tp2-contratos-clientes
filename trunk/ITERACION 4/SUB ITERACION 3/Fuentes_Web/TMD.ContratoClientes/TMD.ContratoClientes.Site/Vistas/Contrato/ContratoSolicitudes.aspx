<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContratoSolicitudes.aspx.cs" Inherits="TMD.CC.Site.Vistas.Contrato.ContratoSolicitudes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="488px">
        <table>
            <tr>
                <td>
                    Tipo de Solicitud</td>
                <td>
                    <asp:DropDownList ID="ddlTipo" runat="server" >
                        <asp:ListItem Value="R">Requerimiento</asp:ListItem>
                        <asp:ListItem Value="C">Cambio</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Razón Social</td>
                <td colspan="2">
                    <asp:TextBox ID="txtRZ" runat="server" MaxLength="100" Width="244px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;&nbsp; &nbsp;</td>
                <td>
                    RUC</td>
                <td>
                    <asp:TextBox ID="txtRUC" runat="server" MaxLength="11" Width="138px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Fecha Inicio</td>
                <td>
                    <asp:TextBox ID="txtFechaIni" runat="server" MaxLength="10" Width="72px">01/01/2012</asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtFechaIni" Display="Dynamic" 
                        ErrorMessage="Ingresar fecha inicio"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    Fecha Fin</td>
                <td>
                    <asp:TextBox ID="txtFechaFin" runat="server" MaxLength="10" Width="72px">21/10/2012</asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtFechaFin" Display="Dynamic" 
                        ErrorMessage="Ingresar fecha fin"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnBuscar" runat="server" onclick="btnBuscar_Click" 
                        Text="Buscar" Width="93px" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:GridView ID="grvSolicitudes" runat="server" AutoGenerateColumns="False" 
                        CellPadding="4" ForeColor="#333333" GridLines="None" 
                        onselectedindexchanged="grvSolicitudes_SelectedIndexChanged" 
                        onpageindexchanging="grvSolicitudes_PageIndexChanging" 
                        onselectedindexchanging="grvSolicitudes_SelectedIndexChanging"
                        DataKeyNames="Id,RucCliente">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField DataField="Id" HeaderText="Id" />
                            <asp:BoundField DataField="RucCliente" HeaderText="RUC" />
                            <asp:BoundField DataField="RazonSocial" HeaderText="Razon Social" />
                            <asp:BoundField DataField="TipoCliente" HeaderText="Tipo Cliente" />
                            <asp:BoundField DataField="TipoSolicitud" HeaderText="Tipo Solicitud" />
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
                    <br />
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
