<%@ Page Title="" Language="C#" MasterPageFile="~/pages/frmMaster.Master" AutoEventWireup="true" CodeBehind="frmCadastrarContatos.aspx.cs" Inherits="SisContatos.pages.WebForm1" %>

<asp:Content ID="contentFrmCadastrarContatoHead" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="contentFrmCadastrarContato" ContentPlaceHolderID="contentPlaceHolderFrmMaster" runat="server">
    <form id="formSalvarContato" runat="server">
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
        <div class="row mt-2">
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
            <asp:TextBox type="tel" class="form-control telefone" ID="txtTelefone" placeholder="Seu telefone" runat="server" />
        </div>
        <div class="col-12 mt-2">
            <asp:Button ID="btnSalvar" type="submit" Text="Salvar" class="btn btn-primary" runat="server" OnClick="btnSalvar_Click" />
        </div>
    </form>
</asp:Content>
