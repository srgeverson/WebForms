using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SisContatos.domain.model;

namespace SisContatos.domain.dao
{
    public class ContatoDAO
    {
        private string sql;
        public void save(Contato contato)
        {
            try
            {

                sql = "";
                sql += "INSERT INTO contatos c (nome, sobre_nome, email, telefone) ";
                sql += "VALUES (";
                sql += string.IsNullOrEmpty(contato.Nome) ? "NULL" : contato.Nome;
                sql += string.IsNullOrEmpty(contato.SobreNome) ? "NULL" : contato.SobreNome;
                sql += string.IsNullOrEmpty(contato.Email) ? "NULL" : contato.Email;
                sql += string.IsNullOrEmpty(contato.Telefone) ? "NULL" : contato.Telefone;
                sql += ")";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void update(Contato contato)
        {
            try
            {
                sql = "";
                sql += "UPDATE contatos c ";
                sql += "SET (";
                sql += string.IsNullOrEmpty(contato.Nome) ? "NULL" : contato.Nome;
                sql += string.IsNullOrEmpty(contato.SobreNome) ? "NULL" : contato.SobreNome;
                sql += string.IsNullOrEmpty(contato.Email) ? "NULL" : contato.Email;
                sql += string.IsNullOrEmpty(contato.Telefone) ? "NULL" : contato.Telefone;
                sql += "WHERE c.id = '" + contato.Id+ "'";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}