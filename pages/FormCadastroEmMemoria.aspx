<%@ Page Title="Cadastro em Memória" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormCadastroEmMemoria.aspx.cs" Inherits="SisContatos.FormCadastroEmMemoria" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div class="row">
        <div class="col-md-2">
            <ul class="nav flex-column">
                <li class="nav-item">
                    <a class="nav-link" runat="server" href="~/pages/FormCadastroEmMemoria.aspx">Cadastrar</a>
                </li>
            </ul>
        </div>
        <div class="col-md-10">
            <div class="row m-2">
                <div class="col-md-1">
                    <asp:Label ID="lblId" for="txtId" class="form-label" runat="server">Código</asp:Label>
                    <asp:TextBox ID="txtId" type="number" class="form-control" placeholder="Código" runat="server" />
                </div>
                <div class="col-md-2">
                    <asp:Label for="txtNome" class="form-label" runat="server">Nome</asp:Label>
                    <asp:TextBox ID="txtNome" type="text" class="form-control" placeholder="Nome" runat="server" />
                </div>
                <div class="col-md-2">
                    <asp:Label ID="lblSobreNome" for="txtSobreNome" class="form-label" runat="server">Sobre Nome</asp:Label>
                    <asp:TextBox ID="txtSobreNome" type="text" class="form-control" placeholder="Sobre nome" runat="server" />
                </div>
                <div class="col-md-3">
                    <asp:Label ID="lblEmail" for="txtEmail" class="form-label" runat="server">E-mail</asp:Label>
                    <asp:TextBox ID="txtEmail" type="text" class="form-control" placeholder="E-mail" runat="server" />
                </div>
                <div class="col-md-2">
                    <asp:Label ID="lblTelefone" for="txtTelefone" class="form-label" runat="server">Telefone</asp:Label>
                    <asp:TextBox ID="txtTelefone" type="text" class="form-control telefone" placeholder="Telefone" runat="server" />
                </div>
            </div>
            <div class="row m-2">
                <div class="col-md-2">
                    <asp:Button ID="btnConsultar" type="submit" Text="Consultar" class="btn btn-success" runat="server" OnClick="btnConsultar_Click" />
                </div>
            </div>
            <div class="row m-2">
                <asp:GridView class="table table-hover" ID="gdvContatos" runat="server"></asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
