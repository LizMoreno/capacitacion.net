<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="practica2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  
        <div class="jumbotron">
            <h1>Bienvenido</h1>
            <p class="lead">Elija una opcion</p>
            <p class="lead">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar Usuarios" />
            </p>
           
                <asp:GridView ID="GridView1"  runat="server" AutoGenerateColumns="False" OnRowEditing="GridView1_RowEditing" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDeleting="GridView1_RowDeleting" OnRowCreated="GridView1_RowCreated" OnRowCommand="GridView1_RowCommand"  >
                    <Columns>
                         
                        <asp:BoundField DataField="idUsuario" 
                            HeaderText="Id" Visible="false"
                             />

                        <asp:BoundField DataField="Email" 
                            HeaderText="Email" ReadOnly="True"
                            SortExpression="Email" />
                       <asp:BoundField DataField="Usuario" 
                            HeaderText="Usuario" ReadOnly="True"
                            SortExpression="Usuario" />
                        <asp:BoundField DataField="Password" 
                            HeaderText="Password" ReadOnly="True"
                            SortExpression="Password" />
                       <asp:ButtonField buttontype="Button" Text="Editar"  CommandName="edit"/>
                       <asp:ButtonField  buttontype="Button" Text="Borrar"   CommandName="delete"
                           />
                    </Columns>
     
                </asp:GridView>
          
     
        </div>
    

    

</asp:Content>
 