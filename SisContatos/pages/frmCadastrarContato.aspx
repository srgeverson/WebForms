<%@ Page Title="" Language="C#" MasterPageFile="~/pages/frmMaster.Master" AutoEventWireup="true" CodeBehind="frmCadastrarContato.aspx.cs" Inherits="SisContatos.pages.WebForm1" %>

<asp:Content ID="contentFrmCadastrarContatoHead" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="contentFrmCadastrarContato" ContentPlaceHolderID="contentPlaceHolderFrmMaster" runat="server">
    <form id="formSalvarContato" runat="server">
        <div class="row">
            <div class="col-md-6">
                <asp:Label ID="lblNome" for="txtNome" class="form-label" runat="server">Nome</asp:Label>
                <asp:TextBox type="text" class="form-control" ID="txtNome" runat="server" />
            </div>
            <div class="col-md-6">
                <asp:Label ID="lblSobrenome" for="txtSobrenome" class="form-label" runat="server">Sobre Nome</asp:Label>
                <asp:TextBox type="text" class="form-control" ID="txtSobrenome" runat="server" />
            </div>
        </div>
        <div class="col-12">
            <asp:Label ID="lblEmail" for="txtEmail" class="form-label" runat="server">E-mail</asp:Label>
            <asp:TextBox type="email" class="form-control" ID="txtEmail" placeholder="Seu email" runat="server" />
        </div>
        <div class="col-12">
            <asp:Label ID="lblTelefone" for="txtTelefone" class="form-label" runat="server">Telefone</asp:Label>
            <asp:TextBox type="tel" class="form-control" ID="txtTelefone" placeholder="Seu telefone" runat="server" />
        </div>
        <div class="col-12 mt-2">
            <asp:Button ID="btnSalvar" type="submit" Text="Salvar" class="btn btn-primary" runat="server" />
        </div>
    </form>
</asp:Content>
