using System;
using SisContatos.domain.service;
using SisContatos.domain.model;
using SisContatos.domain.dao;

namespace SisContatos.pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private IContatoService contatoService;

        protected void Page_Load(object sender, EventArgs e)
        {
            contatoService = new ContatoDAO();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            var contato = new Contato();
            contato.Nome = txtNome.Text;
            contato.SobreNome = txtSobrenome.Text;
            contato.Email = txtEmail.Text;
            contato.Telefone = txtTelefone.Text;
            contatoService.Adicionar(contato);
            limparCampos();
        }

        private void limparCampos()
        {
            txtNome.Text = "";
             txtSobrenome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
        }
    }
}