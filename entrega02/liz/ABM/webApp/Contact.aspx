
<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="webApp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Label ID="lblEditar" runat="server" Text="Editar un usuario" Font-Bold="True" Enabled="False" Font-Size="Large"></asp:Label>
    <br />
    <asp:Label ID="lblAgregar" runat="server" Text="Agregar un nuevo usuario" Font-Bold="True" Enabled="False" Font-Size="Large"></asp:Label>
    <br />
    <br />




    <table >
        <tr>
            <td style="height:35px"> 
    <asp:Label ID="IdNombre" runat="server" Text="Nombre: "></asp:Label>
            </td>
             <td> 
    <asp:TextBox ID="textNombre" runat="server" Width="130px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="idObligatorio1" runat="server" ControlToValidate="textNombre" ErrorMessage="Obligatorio*" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td style="height:35px"> 
    <asp:Label ID="IdEmail" runat="server" Text="Email: "></asp:Label> 
             </td>
             <td><asp:TextBox ID="TextEmail" runat="server" Width="132px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="IdObligatorio2" runat="server" ControlToValidate="TextEmail" ErrorMessage="Obligatorio*" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="IdCorreoValidador" runat="server" ControlToValidate="TextEmail" ErrorMessage="Por favor, introduzca una dirección de correo." SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RegularExpressionValidator>
             </td>
        </tr>
         <tr>
            <td style="height: 22px"> 
    <asp:Label ID="idPass0" runat="server" Text="Password: "></asp:Label> 
             </td>
             <td style="height: 22px">  
    <asp:TextBox ID="TextPass" runat="server" Width="132px" TextMode="Password" ></asp:TextBox>




             &nbsp;&nbsp;Si desea conservar la contraseña actual deje este campo vacío<br />




             </td>
        </tr>
         <tr>
            <td style="height: 20px"> </td>
             <td style="height: 20px"> &nbsp;</td>
        </tr>
    </table>

    <br />
    <br />
    <asp:Button ID="IdAtras" runat="server" Text="Atrás" CausesValidation="false" BackColor="#FF3300" ForeColor="Black" Width="54px" OnClick="IdAtras_Click" />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="IdAgregar" runat="server" Text="Enviar" OnClick="IdAgregar_Click" BackColor="#66FF99" />



</asp:Content>
