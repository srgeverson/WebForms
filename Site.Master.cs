using System;
using System.Web.UI;

namespace SisContatos
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    smdsMenu.ShowStartingNode = false;
                    smpMenu.SiteMapProvider = "XmlMenu";
                    mnMenu.DataSource = smpMenu;
                    mnMenu.DataBind();
                }
                catch { }
            }
        }
    }
}