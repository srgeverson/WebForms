using System;
using System.Web.UI;
using AppClassLibraryDomain.service.implementations;
using SisContatos.domain.model;
using SisContatos.domain.service;
using Spring.Context;
using Spring.Context.Support;

namespace SisContatos
{
    public partial class FormListarEmSQL : Page
    {
        private static IApplicationContext CONTEXT = ContextRegistry.GetContext();
        private static IContatoService contatoService;
        protected void Page_Load(object sender, EventArgs e)
        {
            //contatoService = new ContatoDAO();
            if (!IsPostBack)
            {
            }
            if (contatoService == null)
                contatoService = (ContatoService)CONTEXT.GetObject("ContatoService");
        }

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
                lblErro.Visible = true;
                lblErro.Text = ex.Message;
            }
        }
    }
}