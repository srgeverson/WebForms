using SisContatos.domain.dao;
using SisContatos.domain.model;
using SisContatos.domain.service;
using System;

namespace SisContatos.pages
{
    public partial class frmAlterarContatos : System.Web.UI.Page
    {
        private IContatoService contatoService;
        private Contato contato = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            contatoService = new ContatoDAO();
            LimparCampos(txtId.Enabled);
        }

        private void LimparCampos(bool limpar)
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            btnBuscar.Enabled = txtId.Enabled;
            LimparCampos(txtId.Enabled);
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtId.Text, out id))
            {
                contato = contatoService.Buscar(id);
                if (contato != null)
                {
                    txtId.Enabled = contato.Id > 0;
                    btnBuscar.Enabled = txtId.Enabled;
                    txtNome.Text = contato.Nome;
                    txtSobrenome.Text = contato.SobreNome;
                    txtEmail.Text = contato.Email;
                    txtTelefone.Text = contato.Telefone;
                }
            }
        }
    }
}