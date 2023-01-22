using AppClassLibraryDomain.service;
using Spring.Context;
using Spring.Context.Support;
using System;
using System.Web.UI;

namespace SisContatos
{
    public class BasePage : Page
    {
        private ISistemaService _sistemaService;
        private static readonly IApplicationContext CONTEXT = ContextRegistry.GetContext();

        public ISistemaService SistemaService
        {
            get
            {
                return _sistemaService = _sistemaService == null ? (ISistemaService)CONTEXT.GetObject("SistemaService") : _sistemaService;
            }
        }

        protected void Page_Init(object sender, EventArgs e) { }
    }
}