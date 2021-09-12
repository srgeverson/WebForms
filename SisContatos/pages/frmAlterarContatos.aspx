<%@ Page Title="" Language="C#" MasterPageFile="~/pages/frmMaster.Master" AutoEventWireup="true" CodeBehind="frmAlterarContatos.aspx.cs" Inherits="SisContatos.pages.frmAlterarContatos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentPlaceHolderFrmMaster" runat="server">
    <form id="formAlterarContato" runat="server">
        <div class="row">
            <div class="col-md-1">
                <asp:Label ID="lblId" for="txtId" class="form-label" runat="server">Id</asp:Label>
                <asp:TextBox type="number" class="form-control" ID="txtId" placeholder="Id para alterar" runat="server" />
            </div>
            <div class="col-md-2">
                <br />
                <asp:Button ID="btnBuscar" type="submit" Text="Buscar" class="btn btn-info" runat="server" OnClick="btnBuscar_Click" />
                <asp:Button ID="btnLimpar" type="submit" Text="Limpar" class="btn btn-secondary" runat="server" OnClick="btnLimpar_Click" />
            </div>
            <div class="col-md-9"></div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <asp:Label ID="lblNome" for="txtNome" class="form-label" runat="server">Nome</asp:Label>
                <asp:TextBox type="text" class="form-control" ID="txtNome" placeholder="Seu nome" runat="server" />
            </div>
            <div class="col-md-6">
                <asp:Label ID="lblSobrenome" for="txtSobrenome" class="form-label" runat="server">Sobre Nome</asp:Label>
                <asp:TextBox type="text" class="form-control" ID="txtSobrenome" placeholder="Seu sobre nome" runat="server" />
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
            <asp:Button ID="btnAlterar" type="submit" Text="Alterar" class="btn btn-warning" runat="server" />
        </div>
    </form>
</asp:Content>
