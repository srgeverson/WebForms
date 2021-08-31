using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisContatos
{
    public partial class frmIndex : System.Web.UI.Page
    {
        private static int incrementa = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarLista();
        }
        
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var contato = new Contato();
            incrementa = incrementa + 1;
            contato.Id = incrementa;
            contato.Nome = txtNome.Text;
            contato.Salvar();
            mostrarLista();
        }

        private void mostrarLista()
        {
            pnlCadastro.Visible = false;
            pnlLista.Visible = true;

            grvContatos.DataSource = Contato.Contatos;
            grvContatos.DataBind();
        }

        private void mostrarCadastro()
        {
            pnlCadastro.Visible = true;
            pnlLista.Visible = false;

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            mostrarCadastro();
        }
    }
}