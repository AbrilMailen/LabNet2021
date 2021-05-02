<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="EjercicioEF_ABM_ALTAS_T.aspx.cs" Inherits="LAB.EF.UI.EjercicioEF_ABM_ALTAS_T" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <div class="container-fluid mt-5 mb-5">
            <br />

            <h3 class=" text-center">ABM TERRITORIOS</h3>

            <h4>ALTAS</h4>
            <asp:Label runat="server" ID="lblEstado" Font-Size="X-Large" CssClass="text-center" ForeColor="#3333FF"></asp:Label>
            <div class="form-group forms">
                <asp:Label runat="server" ID="lblID" Text="ID Territorio:"></asp:Label><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="¡Campo Obligatorio!" ControlToValidate="txtID" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:TextBox runat="server" ID="txtID" MaxLength="20" CssClass="form-control"></asp:TextBox>

                <asp:Label runat="server" Text="Descripcion de Territorio"></asp:Label><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="¡Campo Obligatorio!" ControlToValidate="txtDescription" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:TextBox runat="server" ID="txtDescription" MaxLength="50" CssClass="form-control"></asp:TextBox>

                <asp:Label ID="lblRegion" runat="server" Text="Region ID:"></asp:Label>
                <asp:DropDownList runat="server" ID="ddRegion" CssClass="form-control">
                    <asp:ListItem Value="1">Eastern</asp:ListItem>
                    <asp:ListItem Value="2">Western</asp:ListItem>
                    <asp:ListItem Value="3">Northem</asp:ListItem>
                    <asp:ListItem Value="4">Southem</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Button runat="server" CssClass=" btn btn-outline-success" ID="btnAgregarTerritorio" OnClick="btnAgregarTerritorio_Click" Text="Agregar" Width="450px"></asp:Button>
            </div>
        </div>
    </section>
</asp:Content>
