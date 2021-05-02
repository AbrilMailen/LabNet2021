<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="EjercicioEF.aspx.cs" Inherits="LAB.EF.UI.EjercicioEF" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <div class="container-fluid secciones p-xl-4">
            <br />
            <h3 class="text-center m-2">Consultas</h3>
            <br />
            <div class="container-fluid text-center">
                <asp:Button ID="btnListEmpleados" runat="server" Text="Ver empleados" class="btn btn-info" OnClick="btnListEmpleados_Click" />
                <asp:Button ID="btnListTerritorios" runat="server" Text="Ver territorios" class="btn btn-info" OnClick="btnListTerritorios_Click" />
            </div>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label runat="server" ID="lblLista" Font-Size="Large"></asp:Label>
            <asp:ListBox ID="ListBox1" runat="server" Width="90%" Height="300px" class="m-4"></asp:ListBox>
        </div>
    </section>
</asp:Content>
