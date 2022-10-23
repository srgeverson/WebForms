using System;
using System.Web.UI;

namespace SisContatos
{
    public partial class _Default : Page
    {
        private String message;
        public String Message { set => message = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            lblTeste.Text = message;
        }
    }
}