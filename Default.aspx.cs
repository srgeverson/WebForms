using System;
using System.Diagnostics;
using System.Reflection;

namespace SisContatos
{
    public partial class _Default : BasePage
    {
        private String _message;
        public String Message { set => _message = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            lblTeste.Text = _message;
            lblSistema.Text = SistemaService.Sistema(FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductName);
        }
    }
}