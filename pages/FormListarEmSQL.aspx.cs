using System;
using System.Web.UI;
using AppClassLibraryDomain.model;
using AppClassLibraryDomain.service;
using Spring.Context;
using Spring.Context.Support;

namespace SisContatos
{
    public partial class FormListarEmSQL : Page
    {
        //private static IApplicationContext CONTEXT = ContextRegistry.GetContext();
        //private IContatoService contatoService;
        public IUsuarioService UsuarioService { private get; set; }

        public IContatoService ContatoService { private get; set; }
        //public IUsuarioService UsuarioService { set => usuarioService = value; }
        public String Message { private get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //contatoService = new ContatoDAO();
            //if (!IsPostBack)
            //{
            //}
            //if (contatoService == null)
            //    contatoService = (IContatoService)CONTEXT.GetObject("ContatoService");
            //if (UsuarioService == null)
            //    UsuarioService = (IUsuarioService)CONTEXT.GetObject("UsuarioService");
            pnlInformacao.Visible = true;
            lblInformacao.Text = Message;
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
                gdvContatos.DataSource = ContatoService.Listar(contato);
                var usuarios = UsuarioService.Listar(new Usuario());
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