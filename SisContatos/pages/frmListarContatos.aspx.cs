using SisContatos.domain.dao;
using SisContatos.domain.service;
using System;

namespace SisContatos.pages
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private IContatoService contatoService;
        protected void Page_Load(object sender, EventArgs e)
        {
            contatoService = new ContatoDAO();
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            
        }
    }
}