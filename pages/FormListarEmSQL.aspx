﻿<%@ Page Title="Cadastro em Memória" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormListarEmSQL.aspx.cs" Inherits="SisContatos.FormListarEmSQL" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div class="row">
         <div class="row mt-2">
            <div class="col-md-12">
                <asp:Panel ID="pnlAtencao" runat="server" Visible="false">
                    <div class="alert alert-warning alert-dismissible fade show" role="alert">
                        <asp:Label ID="lblAtencao" runat="server">Atenção!</asp:Label>
                    </div>
                </asp:Panel>
                <asp:Panel ID="pnlInformacao" runat="server" Visible="false">
                    <div class="alert alert-info alert-dismissible fade show" role="alert">
                        <asp:Label ID="lblInformacao" runat="server">Informação!</asp:Label>
                    </div>
                </asp:Panel>
                <asp:Panel ID="pnlErro" runat="server" Visible="false">
                    <div class="alert alert-danger alert-dismissible fade show" role="alert">
                        <asp:Label ID="lblErro" runat="server">Erro!</asp:Label>
                    </div>
                </asp:Panel>
            </div>
        </div>
        <div class="col-md-2">
            <ul class="nav flex-column">
                <li class="nav-item">
                    <a class="nav-link" runat="server" href="~/pages/FormCadastroEmSQL.aspx">Cadastrar</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" runat="server" href="~/pages/FormListarEmSQL.aspx">Listar</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" runat="server" href="~/pages/FormAlterarEmSQL.aspx">Alterar</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" runat="server" href="~/pages/FormExcluirEmSQL.aspx">Excluir</a>
                </li>
            </ul>
        </div>
        <div class="col-md-10">
            <%--<form id="formSalvarContato" runat="server">--%>
            <div class="row m-3">
                <div class="col-md-2">
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
            <div class="row mt-3">
                <div class="col-md-2">
                    <asp:Button ID="btnConsultar" type="submit" Text="Consultar" class="btn btn-success" runat="server" OnClick="btnConsultar_Click" />
                </div>
            </div>
            <div class="row m-2">
                <asp:GridView class="table table-hover" ID="gdvContatos" runat="server"></asp:GridView>
            </div>
            <%--</form>--%>
        </div>
    </div>
</asp:Content>