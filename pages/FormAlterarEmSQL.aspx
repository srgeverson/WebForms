<%@ Page Title="Atualizar em SQL" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormAlterarEmSQL.aspx.cs" Inherits="SisContatos.FormAlterarEmSQL" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="row mt-2">
            <div class="col-md-2"></div>
            <div class="col-md-8">
                <h2><%: Title %></h2>
            </div>
        </div>
        <div class="row mt-2">
            <div class="col-md-2"></div>
            <div class="col-md-8">
                <asp:Panel ID="pnlAtencao" runat="server" Visible="false">
                    <div class="alert alert-warning" role="alert">
                        <asp:Label ID="lblAtencao" runat="server">Atenção!</asp:Label>
                    </div>
                </asp:Panel>
                <asp:Panel ID="pnlInformacao" runat="server" Visible="false">
                    <div class="alert alert-info" role="alert">
                        <asp:Label ID="lblInformacao" runat="server">Informação!</asp:Label>
                    </div>
                </asp:Panel>
                <asp:Panel ID="pnlErro" runat="server" Visible="false">
                    <div class="alert alert-danger" role="alert">
                        <asp:Label ID="lblErro" runat="server">Erro!</asp:Label>
                    </div>
                </asp:Panel>
            </div>
        </div>
        <div class="col-md-12">
            <div class="row mt-2">
                <div class="col-md-2"></div>
                <div class="col-md-8">
                    <asp:Label ID="lblId" for="txtId" class="form-label" runat="server">Código</asp:Label>
                    <asp:TextBox type="number" class="form-control" ID="txtId" placeholder="Código" runat="server" />
                </div>
                <div class="col-md-2"></div>
            </div>
            <div class="row mt-2">
                <div class="col-md-2"></div>
                <div class="col-md-4">
                    <asp:Label ID="lblNome" for="txtNome" class="form-label" runat="server">Nome</asp:Label>
                    <asp:TextBox type="text" class="form-control" ID="txtNome" placeholder="Seu nome" runat="server" />
                </div>
                <div class="col-md-4">
                    <asp:Label ID="lblSobrenome" for="txtSobrenome" class="form-label" runat="server">Sobre Nome</asp:Label>
                    <asp:TextBox type="text" class="form-control" ID="txtSobrenome" placeholder="Seu sobre nome" runat="server" />
                </div>
                <div class="col-md-2"></div>
            </div>
            <div class="row mt-2">
                <div class="col-md-2"></div>
                <div class="col-md-8">
                    <asp:Label ID="lblEmail" for="txtEmail" class="form-label" runat="server">E-mail</asp:Label>
                    <asp:TextBox type="email" class="form-control" ID="txtEmail" placeholder="Seu email" runat="server" />
                </div>
                <div class="col-md-2"></div>
            </div>
            <div class="row mt-2">
                <div class="col-md-2"></div>
                <div class="col-md-8">
                    <asp:Label ID="lblTelefone" for="txtTelefone" class="form-label" runat="server">Telefone</asp:Label>
                    <asp:TextBox type="tel" class="form-control telefone" ID="txtTelefone" placeholder="Seu telefone" runat="server" />
                </div>
                <div class="col-md-2"></div>
            </div>
            <br />
            <div class="row mt-2">
                <div class="col-md-2"></div>
                <div class="col-md-8">
                    <asp:Button ID="btnAlterar" type="submit" Text="Alterar" class="btn btn-warning" runat="server" OnClick="btnAlterar_Click" />
                    <asp:Button ID="btnBuscar" type="submit" Text="Buscar" class="btn btn-info" runat="server" OnClick="btnBuscar_Click" />
                    <asp:Button ID="btnLimpar" type="reset" Text="Limpar" class="btn btn-secondary" runat="server" OnClick="btnLimpar_Click" />
                </div>
                <div class="col-md-2"></div>
            </div>
        </div>
    </div>
</asp:Content>
