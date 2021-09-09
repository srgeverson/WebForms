using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisContatos.pages
{
    public partial class frmMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrarContatos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/pages/frmCadastrarContatos.aspx");
        }

        protected void btnListarContatos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/pages/frmListarContatos.aspx");
        }
    }
}