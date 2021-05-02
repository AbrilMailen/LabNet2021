<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="EjercicioEF_ABM_ALTAS.aspx.cs" Inherits="LAB.EF.UI.EjercicioEF_ABM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <div class="container-fluid mt-5 mb-5">
            <br />
            <h3 class=" text-center">ABM EMPLEADOS</h3>
            <h4>ALTAS</h4>
            <asp:Label runat="server" ID="lblEstado" Font-Size="X-Large" CssClass="text-center" ForeColor="#3333FF"></asp:Label>
            <div class="form-group forms">
                
                <label>Nombre:</label><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" ErrorMessage="¡Campo obligatorio!" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" MaxLength="10"></asp:TextBox>
                <label>
                    Apellido:<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtApellido" ErrorMessage="¡Completar!" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </label>
                <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control" MaxLength="20"></asp:TextBox>
                <label>Titulo:</label>
                <asp:TextBox runat="server" ID="txtTitulo" CssClass="form-control" MaxLength="30"></asp:TextBox>
                <label>Titulo de Cortesia:</label>
                <asp:DropDownList runat="server" ID="ddCortesia" CssClass="form-control">
                    <asp:ListItem Value="Mrs."></asp:ListItem>
                    <asp:ListItem Value="Ms."></asp:ListItem>
                    <asp:ListItem Value="Dr."></asp:ListItem>
                    <asp:ListItem Value="Mr."></asp:ListItem>
                </asp:DropDownList>
                <label>Fecha de Nacimiento:</label> 
                <input runat="server" type="date" ID="dateNacimiento"  class="input form-control" placeholder="DD/MM/AAAA" />
                <label>Fecha de Contratacion:</label>
                <input runat="server" type="date" ID="dateContratacion"  class="input form-control" placeholder="DD/MM/AAAA" />
                <label>Direccion:</label>
                <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control" MaxLength="60"></asp:TextBox>
                <label>Ciudad:</label>
                <asp:TextBox runat="server" ID="txtCiudad" CssClass="form-control" MaxLength="15"></asp:TextBox>
                <label>Region:</label>
                <asp:TextBox runat="server" ID="txtRegion" CssClass="form-control" MaxLength="15"></asp:TextBox>
                <label>CP:</label>
                <asp:TextBox runat="server" ID="txtCP" CssClass="form-control" MaxLength="10"></asp:TextBox>
                <label>Pais:</label>
                <asp:TextBox runat="server" ID="txtPais" CssClass="form-control" MaxLength="15"></asp:TextBox>
                <label>Telefono:</label>
                <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control" MaxLength="24" TextMode="Phone"></asp:TextBox>
                <label>Extension:</label>
                <asp:TextBox runat="server" ID="txtExtension" CssClass="form-control" MaxLength="4" TextMode="Number"></asp:TextBox>
                <label>Foto:</label>
                <asp:FileUpload runat="server" ID="fileFoto" CssClass="form-control" Enabled="false" />
                <label>Notas:</label>
                <asp:TextBox runat="server" ID="txtNotas" CssClass="form-control" MaxLength="1000000000" TextMode="MultiLine"></asp:TextBox>
                <label>Informes a:</label>
                <asp:DropDownList runat="server" ID="ddReports" CssClass="form-control">
                    <asp:ListItem Selected="True" Value="null">Ninguno</asp:ListItem>
                </asp:DropDownList>
                <label>Photo Path:</label>
                <asp:TextBox runat="server" ID="txtPhotoPath" CssClass="form-control" TextMode="Url"></asp:TextBox>
                <br />
                <asp:Button runat="server" ID="btnAgregar" Text="Agregar" CssClass="btn btn-outline-success" OnClick="btnAgregar_Click" Width="450px" />
            </div>
          
        </div>
    </section>
</asp:Content>
