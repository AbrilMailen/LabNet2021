<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="EjercicioEF_ABM_MODIFICACIONES.aspx.cs" Inherits="LAB.EF.UI.EjercicioEF_ABM_MODIFICACIONES" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <div class="container-fluid mt-5">
            <br />
            <h3 class=" text-center">ABM EMPLEADOS</h3>
            <h4>MODIFICACIONES</h4>
            <asp:Label runat="server" ID="lblEstado" Font-Size="X-Large" CssClass="text-center" ForeColor="#3333FF"></asp:Label>
            <div class="form-group forms mb-1">
                <br />
                <label>Seleccionar un empleado:</label>
                <asp:DropDownList runat="server" ID="ddEmpleadosModificaciones" CssClass="form-control">
                </asp:DropDownList>
                <br />
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-outline-primary" Width="450px" OnClick="btnModificar_Click" />
            </div>


            <div class="form-group forms mb-5" runat="server" id="divFormularioModificaciones" visible="false">
                <asp:Label runat="server" Enabled="True" ID="lblNombre">Nombre:</asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" ErrorMessage="***" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" MaxLength="10"></asp:TextBox>
                <asp:Label runat="server" ID="lblApellido">Apellido: </asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtApellido" ErrorMessage="***" ForeColor="Red"></asp:RequiredFieldValidator>

                <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control" MaxLength="20"></asp:TextBox>
                <asp:Label runat="server" ID="lblTitulo">Titulo:</asp:Label>
                <asp:TextBox runat="server" ID="txtTitulo" CssClass="form-control" MaxLength="30"></asp:TextBox>
                <asp:Label runat="server" ID="lblTituloCortesia">Titulo de Cortesia:</asp:Label>
                <asp:DropDownList runat="server" ID="ddCortesia" CssClass="form-control">
                    <asp:ListItem Value="Mrs."></asp:ListItem>
                    <asp:ListItem Value="Ms."></asp:ListItem>
                    <asp:ListItem Value="Dr."></asp:ListItem>
                    <asp:ListItem Value="Mr."></asp:ListItem>
                </asp:DropDownList>
                <asp:Label runat="server" ID="lblNacimiento">Fecha de Nacimiento:</asp:Label>
                <br />
                <asp:Label ID="lblNacimientoOld" runat="server" ForeColor="#666666"></asp:Label>
                <input runat="server" type="date" id="dateNacimiento" class="input form-control" placeholder="DD/MM/AAAA" />
                <asp:Label runat="server" ID="lblContrtacion">Fecha de Contratacion:</asp:Label>
                <br />
                <asp:Label ID="lblContratacionOld" runat="server" ForeColor="#666666"></asp:Label>
                <input runat="server" type="date" id="dateContratacion" class="input form-control" placeholder="DD/MM/AAAA" />
                <asp:Label runat="server" ID="lblDireccion">Direccion:</asp:Label>
                <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control" MaxLength="60"></asp:TextBox>
                <asp:Label runat="server" ID="lblCiudad">Ciudad:</asp:Label>
                <asp:TextBox runat="server" ID="txtCiudad" CssClass="form-control" MaxLength="15"></asp:TextBox>
                <asp:Label runat="server" ID="lblregion">Region:</asp:Label>
                <asp:TextBox runat="server" ID="txtRegion" CssClass="form-control" MaxLength="15"></asp:TextBox>
                <asp:Label runat="server" ID="lblCP">CP:</asp:Label>
                <asp:TextBox runat="server" ID="txtCP" CssClass="form-control" MaxLength="10"></asp:TextBox>
                <asp:Label runat="server" ID="lblPais">Pais:</asp:Label>
                <asp:TextBox runat="server" ID="txtPais" CssClass="form-control" MaxLength="15"></asp:TextBox>
                <asp:Label runat="server" ID="lblTelefono">Telefono:</asp:Label>
                <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control" MaxLength="24" TextMode="Phone"></asp:TextBox>
                <asp:Label runat="server" ID="lblExtension">Extension:</asp:Label>
                <asp:TextBox runat="server" ID="txtExtension" CssClass="form-control" MaxLength="4" TextMode="Number"></asp:TextBox>
                <asp:Label runat="server" ID="lblNotas">Notas:</asp:Label>
                <asp:TextBox runat="server" ID="txtNotas" CssClass="form-control" MaxLength="1000000000" TextMode="MultiLine"></asp:TextBox>
                <asp:Label runat="server" ID="lblReports">Informes a:</asp:Label>
                <asp:DropDownList runat="server" ID="ddReports" CssClass="form-control">
                    <asp:ListItem Value="null">Ninguno</asp:ListItem>
                </asp:DropDownList>
                <asp:Label runat="server" ID="lblPhotoPath">Photo Path:</asp:Label>
                <asp:TextBox runat="server" ID="txtPhotoPath" CssClass="form-control" TextMode="Url"></asp:TextBox>
                <br />
                <asp:Button runat="server" ID="btnCambiar" Text="Cambiar" CssClass="btn btn-outline-success" OnClick="btnCambiar_Click" Width="450px" />
            </div>
        </div>
    </section>
</asp:Content>
