<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="subirArchivos.Contact" %>




<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Operaciones</h2>
    <asp:Repeater ID="RepterDetails" runat="server">
        <HeaderTemplate>
            <table style="border: 1px solid #0000FF; ">
                <tr style="background-color: #FF6600; color: #000000; font-size: large; font-weight: bold;">
                    <td>
                        <b>order id</b>
                    </td>
                    <td style="width:200px">
                        <b>account</b>
                    </td>
                    <td>
                        <b>symbol </b>
                    </td>
                    <td>
                        <b>side </b>
                    </td>
                    <td style="width:200px">
                        <b>ord_type </b>
                    </td>
                    <td>
                        <b> order_price </b>
                    </td>
                    <td>
                        <b>order_size </b>
                    </td>
                    <td>
                        <b>exec_inst </b>
                    </td>
                    <td>
                        <b>time_in_force </b>
                    </td>
                    <td>
                        <b>expire_date </b>
                    </td>
                     <td>
                        <b>stop_px  </b>
                    </td>
                    <td>
                        <b>last_cl_ord_id   </b>
                    </td>
                    <td>
                        <b>text </b>
                    </td>
                    <td>
                        <b>exec_type  </b>
                    </td>
                    <td>
                        <b>ord_status   </b>
                    </td>
                    <td>
                        <b>last_price    </b>
                    </td>

                    <td>
                        <b>last_qty   </b>
                    </td>

                    <td>
                        <b>avg_price   </b>
                    </td>

                    <td>
                        <b>cum_qty   </b>
                    </td>

                    <td>
                        <b>leaves_qty   </b>
                    </td>


                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>

                    <asp:Label ID="lblOrderID" runat="server" Text='<%#Eval("order_id") %>' Font-Bold="true" />
                </td>
                <td>

                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("account") %>' Font-Bold="true" />
                </td>
                <td>

                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("symbol") %>' Font-Bold="true" />
                </td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("side") %>' Font-Bold="true" ForeColor="Green" visible='<%# (Eval("side").ToString() == "BUY") %>' />
                   
                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("side") %>' Font-Bold="true" ForeColor="Red" visible='<%# (Eval("side").ToString() == "SELL") %>' />    
                </td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text='<%#Eval("ord_type") %>' Font-Bold="true" />
                </td>
                <td>
                    <asp:Label ID="Label6" runat="server" Text='<%#Eval("order_price") %>' Font-Bold="true" />
                </td>
                <td>
                    <asp:Label ID="Label7" runat="server" Text='<%#Eval("order_size") %>' Font-Bold="true" />
                </td>
                <td>
                    <asp:Label ID="Label8" runat="server" Text='<%#Eval("exec_inst") %>' Font-Bold="true" />
                </td>

                <td>
                    <asp:Label ID="Label9" runat="server" Text='<%#Eval("time_in_force") %>' Font-Bold="true" />
                </td>
                <td>
                    <asp:Label ID="Label10" runat="server" Text='<%#Eval("expire_date") %>' Font-Bold="true" />
                </td>
                <td>
                    <asp:Label ID="Label11" runat="server" Text='<%#Eval("stop_px") %>' Font-Bold="true" />
                </td>
                <td>
                    <asp:Label ID="Label12" runat="server" Text='<%#Eval("last_cl_ord_id") %>' Font-Bold="true" />
                </td>
                <td>
                    <asp:Label ID="Label13" runat="server" Text='<%#Eval("text") %>' Font-Bold="true" />
                </td>

                <td>
                    <asp:Label ID="Label14" runat="server" Text='<%#Eval("exec_type") %>' Font-Bold="true" />
                </td>
                <td>
                    <asp:Label ID="Label15" runat="server" Text='<%#Eval("ord_status") %>' Font-Bold="true" />
                </td>

                <td>
                    <asp:Label ID="Label16" runat="server" Text='<%#Eval("last_price") %>' Font-Bold="true" />
                </td>

                <td>
                    <asp:Label ID="Label17" runat="server" Text='<%#Eval("last_qty") %>' Font-Bold="true" />
                </td>

                <td>
                    <asp:Label ID="Label18" runat="server" Text='<%#Eval("avg_price") %>' Font-Bold="true" />
                </td>
                <td>
                    <asp:Label ID="Label19" runat="server" Text='<%#Eval("cum_qty") %>' Font-Bold="true" />
                </td>
                <td>
                    <asp:Label ID="Label20" runat="server" Text='<%#Eval("leaves_qty") %>' Font-Bold="true" />
                </td>


            </tr>

        </ItemTemplate>


        <FooterTemplate>
            </table>  
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
