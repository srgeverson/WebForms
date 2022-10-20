using System;
using System.Web.UI;
using SisContatos.domain.dao;
using SisContatos.domain.model;
using SisContatos.domain.service;

namespace SisContatos
{
    public partial class FormListarEmSQL : Page
    {
        private IContatoService contatoService;
        protected void Page_Load(object sender, EventArgs e)
        {
            contatoService = new ContatoDAO();
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
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
    }
}