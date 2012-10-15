<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contrato.aspx.cs" Inherits="TMD.CC.Site.Vistas.Contrato.Contrato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style2
        {
            width: 164px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="pnlContrato" runat="server" Height="1424px" Width="644px">
    <table>
        <tr>
            <td align="center" colspan="5">
                DATOS DEL CONTRATO</td>
        </tr>
        <tr>
            <td>
                Nro Solicitud</td>
            <td class="style2">
                <asp:TextBox ID="txtNumSol" runat="server" BorderStyle="Solid" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr style="border-width: thin; border-top-style: inherit; border-right-style: inherit; border-bottom-style: solid; border-left-style: inherit">
            <td>
                Tipo Solicitud</td>
            <td class="style2">
                <asp:TextBox ID="txtTipSol" runat="server" BorderStyle="Solid" ReadOnly="True"></asp:TextBox>
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
                Razón Social</td>
            <td class="style2">
                <asp:TextBox ID="txtRZ" runat="server" Width="229px" BorderStyle="Solid" 
                    ReadOnly="True"></asp:TextBox>
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
                RUC</td>
            <td class="style2">
                <asp:TextBox ID="txtRUC" runat="server" BorderStyle="Solid" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Tipo Cliente</td>
            <td class="style2">
                <asp:TextBox ID="txtTipCli" runat="server" BorderStyle="Solid" ReadOnly="True"></asp:TextBox>
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
                Descripción</td>
            <td colspan="4">
                <asp:TextBox ID="txtDesSol" runat="server" Height="55px" Width="448px" 
                    TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Fecha Inicio</td>
            <td class="style2">
                <asp:TextBox ID="txtFecIni" runat="server" MaxLength="10" Width="72px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                Fecha Fin</td>
            <td>
                <asp:TextBox ID="txtFecFin" runat="server" MaxLength="10" Width="72px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td>
                Linea de Servicio</td>
            <td class="style2">
                <asp:DropDownList ID="ddlLineaServicio" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td colspan="5">Detalle del Contrato</td>
        </tr>
        <tr>
            <td colspan="5">
                  <table style="width:100%;"> 
                                <tr>
                                    <td colspan="3">Garantias</td>
                                   
                                </tr>
                                <tr>
                                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                     <td colspan="2">
                                         <asp:TextBox ID="txtGarantias" runat="server" Height="55px" MaxLength="1000" 
                                             Width="492px" TextMode="MultiLine"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                     <td colspan="3">Bonificaciones</td>
                                </tr>
                                <tr>
                                      <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td> 
                                      <td colspan="2">
                                          <asp:TextBox ID="txtBonificaciones" runat="server" Height="55px" 
                                              MaxLength="1000" Width="484px" TextMode="MultiLine"></asp:TextBox>
                                     </td>
                                </tr>
                                <tr>
                                    <td colspan="3">
                                        Claúsulas &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button ID="btnClausula" runat="server" onclick="btnClausula_Click" 
                                            Text="+" Height="21px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                    <td  colspan="2">
                                        <asp:GridView ID="grvClausulaC" runat="server" AutoGenerateColumns="False" 
                                            CellPadding="4" ForeColor="#333333" GridLines="None">
                                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                            <Columns>
                                                <asp:BoundField DataField="Id" HeaderText="Código" />
                                                <asp:BoundField DataField="DesCorta" HeaderText="Descripción" />
                                                <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
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
                                </tr>
                                <tr>
                                    <td colspan="3">Penalidades &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button ID="btnPenalidades" runat="server" onclick="btnPenalidades_Click" 
                                            Text="+" Height="21px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                    <td  colspan="2">
                                        <asp:GridView ID="grvPenalidadesC" runat="server" AutoGenerateColumns="False" 
                                            CellPadding="4" DataKeyNames="Id" ForeColor="#333333" GridLines="None">
                                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                            <Columns>
                                                <asp:BoundField DataField="Id" HeaderText="Código" />
                                                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                                                <asp:BoundField DataField="Porcentaje" HeaderText="Porcentaje" />
                                                <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
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
                                </tr>
                                <tr>
                                    <td colspan="3">Indicadores &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button ID="btnIndicadores" runat="server" onclick="btnIndicadores_Click" 
                                            Text="+" Height="21px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                    <td  colspan="2">
                                        <asp:GridView ID="grvIndicadoresC" runat="server" AutoGenerateColumns="False" 
                                            CellPadding="4" DataKeyNames="Id" ForeColor="#333333" GridLines="None">
                                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                            <Columns>
                                                <asp:BoundField DataField="Id" HeaderText="Código" />
                                                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                                                <asp:BoundField DataField="Frecuencia" HeaderText="Frecuencia" />
                                                <asp:BoundField DataField="ValorObjetivo" HeaderText="Valor Objetivo" />
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
                                </tr>
                                <tr>
                                    <td colspan="3">Entregables  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button ID="btnEntregables" runat="server" onclick="btnEntregables_Click" 
                                            Text="+" Height="21px" />
                                    </td>
                                </tr>
                                 <tr>
                                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                    <td  colspan="2">
                                        <asp:GridView ID="grvEntregablesC" runat="server" AutoGenerateColumns="False" 
                                            CellPadding="4" DataKeyNames="Id,Descripcion" ForeColor="#333333" 
                                            GridLines="None">
                                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                            <Columns>
                                                <asp:BoundField DataField="Id" HeaderText="Código" />
                                                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                                                <asp:BoundField DataField="FechaPactada" HeaderText="Fecha Pactada" />
                                                <asp:BoundField DataField="Responsable" HeaderText="Responsable" />
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
                                </tr>
                                <tr>
                                    <td colspan="3">Roles  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button ID="btnRoles" runat="server"  
                                            Text="+" Height="21px" onclick="btnRoles_Click" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                    <td  colspan="2">
                                        <asp:GridView ID="grvRolesC" runat="server" AutoGenerateColumns="False" 
                                            CellPadding="4" DataKeyNames="Id" ForeColor="#333333" 
                                            GridLines="None">
                                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                            <Columns>
                                                <asp:BoundField DataField="Id" HeaderText="Código" />
                                                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
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
                                </tr>
                             </table>

                <br>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="5">
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" 
                    onclick="btnAceptar_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
            </td>
        </tr>
    </table>
</asp:Panel>
<asp:Panel ID="pnlClausulas" runat="server" Visible="False">
    <table>
        <tr>
            <td>
                Claúsulas</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grvClausula" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" GridLines="None"
                    DataKeyNames="Id,DesCorta,Tipo">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Código" />
                        <asp:BoundField DataField="DesCorta" HeaderText="Descripción" />
                        <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                        <asp:CommandField ShowSelectButton="True" />
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
        </tr>
        <tr>
            <td align="center">
                <asp:Button ID="btnAceptarC" runat="server" onclick="btnAceptarC_Click" 
                    Text="Aceptar" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancelarC" runat="server" onclick="btnCancelarC_Click" 
                    Text="Cancelar" />
            </td>
        </tr>
    </table>
    
   </asp:Panel>
   <asp:Panel ID="pnlPenalidades" runat="server" Visible="False">
    <table>
        <tr>
            <td>
                Penalidades</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grvPenalidades" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" GridLines="None" 
                    DataKeyNames="Id,Descripcion,Porcentaje,Tipo">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Código" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                        <asp:BoundField DataField="Porcentaje" HeaderText="Porcentaje" />
                        <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                        <asp:CommandField ShowSelectButton="True" />
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
        </tr>
        <tr>
            <td align="center">
                <asp:Button ID="btnAceptarP" runat="server" 
                    Text="Aceptar" onclick="btnAceptarP_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancelarP" runat="server"  
                    Text="Cancelar" onclick="btnCancelarP_Click" />
            </td>
        </tr>
    </table>
    
   </asp:Panel>
   <asp:Panel ID="pnlIndicadores" runat="server" Visible="False">
    <table>
        <tr>
            <td colspan="2">Indicadores</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="grvIndicadores" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" GridLines="None" 
                    DataKeyNames="Id,Descripcion,Frecuencia">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Código" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                        <asp:BoundField DataField="Frecuencia" HeaderText="Frecuencia" />
                        <asp:CommandField ShowSelectButton="True" />
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
           <tr>
            <td>Valor Objetivo</td> 
             <td><asp:TextBox ID="txtVO" runat="server" MaxLength="10"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="btnAceptarI" runat="server" 
                    Text="Aceptar" onclick="btnAceptarI_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancelarI" runat="server"  
                    Text="Cancelar" onclick="btnCancelarI_Click"  />
            </td>
        </tr>
        
    </table>
    
   </asp:Panel>
   <asp:Panel ID="pnlEntregables" runat="server" Visible="False">
    <table>
        <tr>
            <td colspan="2">Entregables</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="grvEntregables" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" GridLines="None" 
                    DataKeyNames="Id,Descripcion">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Código" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                        <asp:CommandField ShowSelectButton="True" />
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
       
        <tr>
            <td>Fecha Pactada</td> 
             <td><asp:TextBox ID="txtFechaP" runat="server" MaxLength="10" Width="87px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Responsable</td> 
             <td><asp:TextBox ID="txtResponsable" runat="server" MaxLength="30" Width="199px"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td align="center" colspan="2">
                <asp:Button ID="btnAceptarE" runat="server" 
                    Text="Aceptar" onclick="btnAceptarE_Click"  />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancelarE" runat="server"  
                    Text="Cancelar" onclick="btnCancelarE_Click"  />
            </td>
        </tr>
    </table>
    
   </asp:Panel>
   <asp:Panel ID="pnlRoles" runat="server" Visible="False">
    <table>
        <tr>
            <td colspan="2">Roles</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="grvRoles" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" GridLines="None" 
                    DataKeyNames="Id,Nombre">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Código" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:CommandField ShowSelectButton="True" />
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
             
         <tr>
            <td align="center" colspan="2">
                <asp:Button ID="btnAceptarR" runat="server" 
                    Text="Aceptar" onclick="btnAceptarR_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="bnCancelarR" runat="server"  
                    Text="Cancelar" onclick="bnCancelarR_Click"  />
            </td>
        </tr>
    </table>
    
   </asp:Panel>
</asp:Content>
