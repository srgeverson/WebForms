//using SisContatos.domain;
//using SisContatos.domain.model;
using Spring.Context;
using Spring.Context.Support;
using System;
using System.Web.UI;

namespace SisContatos
{
    public partial class About : Page
    {
        //private IUsuarioService usuarioService;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTesteSpring_Click(object sender, EventArgs e)
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            //UsuarioDTO lister = (UsuarioDTO)ctx.GetObject("MyUsuarioDTO");
        }
    }
}