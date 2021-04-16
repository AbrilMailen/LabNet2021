<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjercicioPOO.aspx.cs" Inherits="POO_LAB_Transporte.EjercicioPOO1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
 <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
       <script src="Scripts/jquery-3.0.0.js"></script>
       <script src="Scripts/bootstrap.js"></script>
        <script src="https://kit.fontawesome.com/fc8b58d044.js" crossorigin="anonymous"></script>
        <link href="css/base.css" rel="stylesheet" />
       <link href="Content/bootstrap.css" rel="stylesheet" />

           <title>Lab .NET 2021</title>
    </head>
<body style="background-color:cadetblue">
      <form id="form1" runat="server">
        <div>
            <nav id="navbar" class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
                <div class="container">
                    <a class="navbar-brand" href="EjercicioPOO.aspx">
                       LAB .NET 2021
                    </a>
                   <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarCollapse" aria-controls="navbarCollapse" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="collapse navbar-collapse" id="navbarCollapse">
                        <ul class="navbar-nav navbar-center ml-auto">
                            <li class="nav-item ml-3">
                                <a class="nav-link" href="EjercicioPOO.aspx">Unidad 2<span class="sr-only">(current)</span></a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>

          <section>
    <div class="container-fluid secciones p-xl-4">
        <h3 class="text-center m-2">
            Resultados:
        </h3>
        
        <asp:Label runat="server" ID="lblResultadosAvion"></asp:Label>
        <br />
        <asp:Label runat="server" ID="lblResultadosAutomovil"></asp:Label>

        <br />
        <div>
        <asp:DropDownList ID="DropDownList1" runat="server" Class="form-control" Width="240px">
            <asp:ListItem Value="0">Avion 1</asp:ListItem>
            <asp:ListItem Value="2">Avion 2</asp:ListItem>
            <asp:ListItem Value="4">Avion 3</asp:ListItem>
            <asp:ListItem Value="6">Avion 4</asp:ListItem>
            <asp:ListItem Value="8">Avion 5</asp:ListItem>
            <asp:ListItem Value="1">Automovil 1</asp:ListItem>
            <asp:ListItem Value="3">Automovil 2</asp:ListItem>
            <asp:ListItem Value="5">Automovil 3</asp:ListItem>
            <asp:ListItem Value="7">Automovil 4</asp:ListItem>
            <asp:ListItem Value="9">Automovil 5</asp:ListItem>
        </asp:DropDownList>
        
        <asp:Button ID="btnAvanzar" runat="server" Text="Avanzar" class="btn btn-success m-1" OnClick="btnAvanzar_Click" Width="108px"/>
        <asp:Button ID="btnDetenerse" runat="server" Text="Detenerse" class="btn btn-danger m-1" OnClick="btnDetenerse_Click" Width="110px" />

            &nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblAvanzarDetenerse" runat="server" Font-Size="medium"></asp:Label>

            <br />

        <br />
        </div>
    </div>
</section>
            
         <footer class="container-fluid fixed-bottom mt-2 p-2">
             <p>Pagina Web desarrollada por Abril Arce. @2021.</p>
             <a href="https://github.com/AbrilMailen/" target="_blank"><i class="fab fa-github fa-2x  text-white icono pr-3"></i></a>
             <a href="mailto:abril.mailen.am@gmail.com"><i class="far fa-envelope fa-2x icono text-white pr-3"></i></a>
        </footer>

        </div>
     </form>
    </body>
</html>
