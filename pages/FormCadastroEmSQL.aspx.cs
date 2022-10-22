using AppClassLibraryDomain.model;
using AppClassLibraryDomain.service;
using System;
using System.Web.UI;

namespace SisContatos
{
    public partial class FormCadastroEmSQL : Page
    {
        private IContatoService contatoService;

        protected void Page_Load(object sender, EventArgs e)
        {
            //contatoService = new ContatoDAO();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var contato = new Contato();
                contato.Nome = txtNome.Text;
                contato.SobreNome = txtSobrenome.Text;
                contato.Email = txtEmail.Text;
                contato.Telefone = txtTelefone.Text;
                contatoService.Adicionar(contato);
                LimparCampos();
                InformaOperacao("", "", "Cadastro realizado com sucesso!");
            }
            catch (Exception ex)
            {
                InformaOperacao("", "Erro ao realizar cadastro! Erro: " + ex.Message, "");
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
        }

        private void InformaOperacao(string atencao, string erro, string informacao)
        {
            lblAtencao.Text = atencao;
            pnlAtencao.Visible = !string.IsNullOrEmpty(atencao);
            lblErro.Text = erro;
            pnlErro.Visible = !string.IsNullOrEmpty(erro);
            lblInformacao.Text = informacao;
            pnlInformacao.Visible = !string.IsNullOrEmpty(informacao);
        }
    }
}