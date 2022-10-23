<%@ Page Title="Listar em SQL" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormListarEmSQL.aspx.cs" Inherits="SisContatos.FormListarEmSQL" %>

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
        <div class="row mt-2">
            <div class="col-md-2"></div>
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
            <div class="col-md-2">
                <asp:Label ID="lblEmail" for="txtEmail" class="form-label" runat="server">E-mail</asp:Label>
                <asp:TextBox ID="txtEmail" type="text" class="form-control" placeholder="E-mail" runat="server" />
            </div>
            <div class="col-md-2">
                <asp:Label ID="lblTelefone" for="txtTelefone" class="form-label" runat="server">Telefone</asp:Label>
                <asp:TextBox ID="txtTelefone" type="text" class="form-control telefone" placeholder="Telefone" runat="server" />
            </div>
        </div>
        <br />
        <div class="row mt-2">
            <div class="col-md-2"></div>
            <div class="col-md-8">
                <asp:Button ID="btnConsultar" type="submit" Text="Consultar" class="btn btn-success" runat="server" OnClick="btnConsultar_Click" />
            </div>
            <div class="col-md-2"></div>
        </div>
        <br />
        <div class="row m-2">
            <div class="col-md-2"></div>
            <div class="col-md-8">
                <asp:GridView class="table table-hover" ID="gdvContatos" runat="server"></asp:GridView>
            </div>
            <div class="col-md-2"></div>
        </div>
    </div>
    </div>
</asp:Content>
