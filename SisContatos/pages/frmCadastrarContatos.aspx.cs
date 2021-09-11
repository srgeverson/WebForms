using System;
using SisContatos.domain.service;
using SisContatos.domain.model;

namespace SisContatos.pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private ContatoService contatoService;

        protected void Page_Load(object sender, EventArgs e)
        {
            contatoService = new ContatoService();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            var contato = new Contato();
            contato.Nome = txtNome.Text;
            contato.SobreNome = txtSobrenome.Text;
            contato.Email = txtEmail.Text;
            contato.Telefone = txtTelefone.Text;
            contatoService.adicionar(contato);
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