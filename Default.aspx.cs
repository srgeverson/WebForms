using System;
using System.Web.UI;

namespace SisContatos
{
    public partial class _Default : Page
    {
        //private String message;
        //private static IApplicationContext CONTEXT = ContextRegistry.GetContext();

        public String Message { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //var teste = (String)CONTEXT.GetObject("message");
            lblTeste.Text = Message;
        }
    }
}