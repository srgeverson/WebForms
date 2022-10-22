using AppClassLibraryDomain.model;
using AppClassLibraryDomain.service;
using System;
using System.Web.UI;

namespace SisContatos
{
    public partial class FormExcluirEmSQL : Page
    {
        private IContatoService contatoService;
        private Contato contato = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            //contatoService = new ContatoDAO();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                contatoService.Excluir(int.Parse(txtId.Text));
                LimparCampos();
                InformaOperacao("", "", "Exclusão realizada com sucesso!");
                btnBuscar.Enabled = true;
                BloquearCampos(!btnBuscar.Enabled);
            }
            catch (Exception ex)
            {
                InformaOperacao("", "Erro ao excluir cadastro! Erro: " + ex.Message, "");
            }
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
                        btnBuscar.Enabled = false;
                        BloquearCampos(!btnBuscar.Enabled);
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

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            InformaOperacao("", "", "");
            btnBuscar.Enabled = true;
            BloquearCampos(!btnBuscar.Enabled);
        }

        private void LimparCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
        }

        private void BloquearCampos(bool bloquear)
        {
            txtId.ReadOnly = bloquear;
            txtNome.ReadOnly = bloquear;
            txtSobrenome.ReadOnly = bloquear;
            txtEmail.ReadOnly = bloquear;
            txtTelefone.ReadOnly = bloquear;
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