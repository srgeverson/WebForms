<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmIndex.aspx.cs" Inherits="SisContatos.frmIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>SisContatos</title>
    <style type="text/css">
        #txtNome {
            height: 16px;
            margin-top: 22px;
        }
        #Button1 {
            height: 20px;
            width: 74px;
            margin-left: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 73px; width: 365px">
            <asp:Panel ID="pnlCadastro" runat="server" Height="60px" Width="364px">
                Nome:
                <asp:TextBox ID="txtNome" runat="server" Height="20px"></asp:TextBox>
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            </asp:Panel>
        </div>
        <br />
        <div style="height: 169px; width: 367px">
            <asp:Panel ID="pnlLista" runat="server" Height="146px" Width="214px">
                <asp:Button ID="btnCadastro" runat="server" Text="Cadastra" OnClick="btnCadastro_Click" />
                <br />
                <asp:GridView ID="grvContatos" runat="server" Height="116px" Width="207px">
                </asp:GridView>                              
            </asp:Panel>
        </div>
    </form>
</body>
</html>
