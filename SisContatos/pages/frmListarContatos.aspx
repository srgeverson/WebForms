<%@ Page Title="" Language="C#" MasterPageFile="~/pages/frmMaster.Master" AutoEventWireup="true" CodeBehind="frmListarContatos.aspx.cs" Inherits="SisContatos.pages.WebForm2" %>

<asp:Content ID="contentFrmListarContatosHead" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="contentFrmListarContatos" ContentPlaceHolderID="contentPlaceHolderFrmMaster" runat="server">
    <form id="formListarContato" runat="server">
        <div class="row m-2">
            <div class="col-md-1">
                <asp:Label ID="lblId" for="txtId" class="form-label" runat="server">Codigo</asp:Label>
                <asp:TextBox ID="txtId" type="text" class="form-control" runat="server" />
            </div>
            <div class="col-md-2">
                <asp:Label for="txtNome" class="form-label" runat="server">Nome</asp:Label>
                <asp:TextBox ID="txtNome" type="text" class="form-control" runat="server" />
            </div>
            <div class="col-md-2">
                <asp:Label ID="lblSobreNome" for="txtSobreNome" class="form-label" runat="server">Sobre Nome</asp:Label>
                <asp:TextBox ID="txtSobreNome" type="text" class="form-control" runat="server" />
            </div>
            <div class="col-md-3">
                <asp:Label ID="lblEmail" for="txtEmail" class="form-label" runat="server">Email</asp:Label>
                <asp:TextBox ID="txtEmail" type="text" class="form-control" runat="server" />
            </div>
            <div class="col-md-2">
                <asp:Label ID="lblTelefone" for="txtTelefone" class="form-label" runat="server">Telefone</asp:Label>
                <asp:TextBox ID="txtTelefone" type="text" class="form-control" runat="server" />
            </div>
        </div>
        <div class="row m-2">
            <div class="col-md-2">
                <asp:Button ID="btnConsultar" type="submit" Text="Consultar" class="btn btn-success" runat="server" OnClick="btnConsultar_Click" />
            </div>
        </div>
    </form>
    <table class="table">
        <thead>
            <tr>
                <th scope="col">Código</th>
                <th scope="col">Nome</th>
                <th scope="col">Sobre Nome</th>
                <th scope="col">Email</th>
                <th scope="col">Telefone</th>
            </tr>
        </thead>
        <tbody>
        </tbody>
    </table>
</asp:Content>
