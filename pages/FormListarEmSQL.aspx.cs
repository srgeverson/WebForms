using System;
using System.Web.UI;
using AppClassLibraryDomain.model;
using AppClassLibraryDomain.service;

namespace SisContatos
{
    public partial class FormListarEmSQL : Page
    {
        private IContatoService contatoService;
        public IContatoService ContatoService { set => contatoService = value; }

        protected void Page_Load(object sender, EventArgs e) { }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                var contato = new Contato();
                int id;
                if (int.TryParse(txtId.Text, out id))
                    contato.Id = int.Parse(txtId.Text);
                contato.Nome = txtNome.Text;
                contato.SobreNome = txtSobreNome.Text;
                contato.Email = txtEmail.Text;
                contato.Telefone = txtTelefone.Text;
                gdvContatos.DataSource = contatoService.Listar(contato);
                gdvContatos.DataBind();
            }
            catch (Exception ex)
            {
                lblErro.Text = ex.Message;
                pnlErro.Visible = true;
            }
        }
    }
}