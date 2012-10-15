<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaLineaBase.aspx.cs" Inherits="TMD.CC.Site.Vistas.LineaBase.ListaLineaBase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="listaLB" class="content">
        <h1 class="page-title">LISTA DE LINEAS BASE</h1>
        <div class="panel-wrapper">
                <table style="width: 800px;">
                    <tr>
                        <td>
                            <label>Proyecto</label>
                            <asp:DropDownList ID="DropDownList1" runat="server">
                            </asp:DropDownList> 
                        </td>
                        <td>
                            <label>Fase</label>
                            <asp:DropDownList ID="DropDownList2" runat="server">
                            </asp:DropDownList> 
                        </td>
                    </tr>
                </table>
        </div>
        <asp:GridView ID="GridListaLB" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre Linea Base" />
                <asp:BoundField DataField="responsable" HeaderText="Responsable" />

            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
