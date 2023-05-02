<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Site.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>HOME</title>
    <link type ="text/css" rel ="stylesheet" href="Content/bootstrap.css" />
    <script src ="Scripts/jquery-1.9.0.min.js"></script>
    <script src ="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <h1> Crud - cadastro de  Clientes</h1>

            Selecione a operação desejada:
            <asp:DropDownList ID="ddlMenu" runat="server">
                <asp:ListItem value="0" Text="Escolha uma Opção" />
                <asp:ListItem value="1" Text="Cadastrar Usuário" />
                <asp:ListItem value="2" Text="Consultar Usuário" />
                <asp:ListItem value="3" Text="Obter os Dados do Usuário" />
            </asp:DropDownList>
            <asp:Button ID= "btnMenu" Text="Acessar" runat="server" CssClass="btn btn-primary btn-lg" OnClick="btnAcessar" />

            <p>
                <asp:Label ID= "lblMensagem" runat="server" />
            </p>
        </div>
    </form>
</body>
</html>
