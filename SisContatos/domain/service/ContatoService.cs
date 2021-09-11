using SisContatos.domain.model;
using SisContatos.domain.dao;
using SisContatos.domain.exception;
using System;

namespace SisContatos.domain.service
{
    public class ContatoService
    {
        private ContatoDAO contatoDAO;
        public void adicionar(Contato contato)
        {
            try
            {
                contatoDAO = new ContatoDAO();
                contatoDAO.Save(contato);
            }catch(Exception ex)
            {
                throw new NegocioException("Erro na regra de negocio ao cadastrar. Erro: ", ex);
            }
        }
    }
}
