<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro</title>
    <link type ="text/css" rel ="stylesheet" href="Content/bootstrap.css" />
    <script src ="Scripts/jquery-1.9.0.min.js"></script>
    <script src ="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
         <div class="container">
            <div class ="span10 offset1">
                <div class="row">
                    <h3 class="well">Cadastro de Usuario</h3>
                    <br />

                    Nome do Usuario: <br />
                    <asp:TextBox ID="txtNome" runat="server" placeholder="Nome completo" Width="45%" CssClass="form-control" />
                    <asp:RequiredFieldValidator 
                        ID="requiredNome" 
                        ErrorMessage="Por favor, digite o seu Nome" 
                        ControlToValidate="txtNome" 
                        runat="server" 
                        foreColor="Red"
                        />
                    <br />
                    <br />
                    Senha do usuario: <br />
                    <asp:TextBox ID="txtSenha" runat="server" placeholder="Senha valida" Width="50%" CssClass="form-control" />
                    <asp:RequiredFieldValidator 
                        ID="RequiredEndereco" 
                        ErrorMessage="Por favor, digite a sua senha" 
                        ControlToValidate="txtSenha" 
                        runat="server" 
                        foreColor="Red"
                        />
                    <br />
                    <br />
                    Email do Usuario:<br />
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="Email válido" Width="25%" CssClass="form-control" />
                    <asp:RequiredFieldValidator 
                        ID="RequiredEmail" 
                        ErrorMessage="Por favor, digite o seu Email" 
                        ControlToValidate="txtEmail" 
                        runat="server" 
                        foreColor="Red"
                        />
                    <br />
                    <br />

                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>

                    <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success btn-lg" OnClick="btnCadastrarUsuario" />
                    <a href="/Index.aspx" class="btn btn-default btn-lg">Voltar</a>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
