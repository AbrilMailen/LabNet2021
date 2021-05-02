<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="EjercicioEF_ABM_BAJAS_T.aspx.cs" Inherits="LAB.EF.UI.EjercicioEF_ABM_BAJAS_T" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section>
        <div class="container-fluid mt-5">
            <br />
            <h3 class=" text-center">ABM TERRITORIOS</h3>
            <h4>BAJAS</h4>
             <asp:Label runat="server" ID="lblEstado" Font-Size="X-Large" CssClass="text-center" ForeColor="#3333FF"></asp:Label>
            <div class="form-group forms mb-5">
                <br />
                <label>Seleccionar un territorio:</label>
                <asp:DropDownList runat="server" ID="ddTerritoriosBajas" CssClass="form-control" >
                    <asp:ListItem Selected="True" Value="null">Ninguno</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" Width="450px" OnClick="btnEliminar_Click" />
            </div>
        </div>
    </section>
</asp:Content>
