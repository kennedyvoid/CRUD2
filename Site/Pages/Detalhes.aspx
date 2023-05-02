<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Pages.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Detelhes</title>
    <link type ="text/css" rel ="stylesheet" href="Content/bootstrap.css" />
    <script src ="Scripts/jquery-1.9.0.min.js"></script>
    <script src ="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        
         <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Detalhes do Clientes</h3>
                    Informe o ID:
                    <br />
                    <asp:TextBox ID="txtId" runat="server" CssClass="form-control" Width="5%"/>
                    <br />
                    <asp:Button ID="btnPesquisa" Text="Pesquisar" runat="server" CssClass="btn btn-info btn-lg" onclick="btnPesquisarUsuario"/>
                    <a href="/Index.aspx" class="btn btn-default btn-lg">Voltar</a>
                    <br />
                    <br />
                    <br />
                    <asp:Panel ID="pnlDados" runat="server">
                    Nome do Usuário:<br />  
                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" Width="45%"/>
                    <br />
                    <br />
                    Senha do Usuário:<br />
                    <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" Width="50%"/>
                    <br />
                    <br />
                    Email do Usuário:<br />
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Width="25%"/>
                    <br />
                    <br />

                    <asp:Button ID="btnExclui" Text="Excluir" runat="server" CssClass="btn btn-danger btn-lg" OnClick="btnExcluirCliente" />

                    <asp:Button ID="btnAtualiza" Text="Atualizar" runat="server" CssClass="btn btn-warning btn-lg" OnClick="btnAtualizarCliente" />

                    </asp:Panel>

                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>
                    
                </div>
            </div>
        </div>
    </form>
</body>
</html>
