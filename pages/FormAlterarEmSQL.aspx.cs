using System;
using System.Web.UI;
using SisContatos.domain.service;
using SisContatos.domain.model;
using SisContatos.domain.dao;

namespace SisContatos
{
    public partial class FormAlterarEmSQL : Page
    {
        private IContatoService contatoService;
        private Contato contato = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            contatoService = new ContatoDAO();
        }

        private void LimparCampos()
        {
            txtId.ReadOnly = false;
            btnBuscar.Enabled = !txtId.ReadOnly;
            txtId.Text = "";
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

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            InformaOperacao("", "", "");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                if (int.TryParse(txtId.Text, out id))
                {
                    contato = contatoService.Buscar(id);
                    if (contato != null)
                    {
                        btnBuscar.Enabled = !(contato.Id > 0);
                        txtId.ReadOnly = !btnBuscar.Enabled;
                        InformaOperacao("", "", "");
                        txtNome.Text = contato.Nome;
                        txtSobrenome.Text = contato.SobreNome;
                        txtEmail.Text = contato.Email;
                        txtTelefone.Text = contato.Telefone;
                    }
                    else
                    {
                        InformaOperacao("Não foi encontrado contato com este ID!", "", "");
                    }
                }
            }
            catch (Exception ex)
            {
                InformaOperacao("", "Erro ao consultar cadastro! Erro: " + ex.Message, "");
            }
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                var contato = new Contato();
                contato.Id = int.Parse(txtId.Text);
                contato.Nome = txtNome.Text;
                contato.SobreNome = txtSobrenome.Text;
                contato.Email = txtEmail.Text;
                contato.Telefone = txtTelefone.Text;
                contatoService.Alterar(contato);
                LimparCampos();
                InformaOperacao("", "", "Alteração realizada com sucesso!");
            }
            catch (Exception ex)
            {
                InformaOperacao("", "Erro ao alterar cadastro! Erro: " + ex.Message, "");
            }
        }
    }
}