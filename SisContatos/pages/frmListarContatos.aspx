<%@ Page Title="" Language="C#" MasterPageFile="~/pages/frmMaster.Master" AutoEventWireup="true" CodeBehind="frmListarContatos.aspx.cs" Inherits="SisContatos.pages.WebForm2" %>

<asp:Content ID="contentFrmListarContatosHead" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="contentFrmListarContatos" ContentPlaceHolderID="contentPlaceHolderFrmMaster" runat="server">
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
