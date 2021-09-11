<%@ Page Title="" Language="C#" MasterPageFile="~/pages/frmMaster.Master" AutoEventWireup="true" CodeBehind="frmListarContatos.aspx.cs" Inherits="SisContatos.pages.WebForm2" %>

<asp:Content ID="contentFrmListarContatosHead" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="contentFrmListarContatos" ContentPlaceHolderID="contentPlaceHolderFrmMaster" runat="server">
    <div class="row">
        <form id="formListarContato" runat="server">
            <div class="col-md-6">
                <label for="inputCity" class="form-label">City</label>
                <input type="text" class="form-control" id="inputCity">
            </div>
            <div class="col-md-4">
                <label for="inputState" class="form-label">State</label>
                <select id="inputState" class="form-select">
                    <option selected>Choose...</option>
                    <option>...</option>
                </select>
            </div>
            <div class="col-md-2">
                <label for="inputZip" class="form-label">Zip</label>
                <input type="text" class="form-control" id="inputZip">
            </div>
            <div class="col-md-2">
                <asp:Button ID="btnConsultar" type="submit" Text="Consultar" class="btn btn-success" runat="server" OnClick="btnConsultar_Click" />
            </div>
        </form>
    </div>
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
