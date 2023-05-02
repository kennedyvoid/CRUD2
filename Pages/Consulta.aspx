 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Site.Pages.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consulta</title>
    <link type ="text/css" rel ="stylesheet" href="Content/bootstrap.css" />
    <script src ="Scripts/jquery-1.9.0.min.js"></script>
    <script src ="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Consulta de Usuario</h3>

                    <asp:GridView ID="gridPista" runat="server" CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="true" BackColor="#99ff99">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id" /> 
                            <asp:BoundField DataField="Nome" HeaderText="Nome" /> 
                            <asp:BoundField DataField="Senha" HeaderText="Senha" />
                            <asp:BoundField DataField="Email" HeaderText="Email" />
                        </Columns>
                        <RowStyle CssClass="cursor-pointer" />
                    </asp:GridView>

                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>

                    <a href="/Index.aspx" class="btn btn-default btn-lg">Voltar</a>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
