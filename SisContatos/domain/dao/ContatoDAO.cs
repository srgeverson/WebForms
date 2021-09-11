using System;
using System.Data.SqlClient;
using SisContatos.domain.model;
using SisContatos.domain.exception;
using System.Collections.Generic;
using System.Data.Common;

namespace SisContatos.domain.dao
{
    public class ContatoDAO : ConexaoDAO
    {
        private string sql;
        private DbDataReader dbDataReader = null;
        public void Save(Contato contato)
        {
            try
            {
                sql = "";
                sql += "INSERT INTO contatos (nome, sobre_nome, email, telefone) VALUES (@nome, @sobre_nome, @email, @telefone) ";
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@nome", contato.Nome));
                parameters.Add(new SqlParameter("@sobre_nome", contato.SobreNome));
                parameters.Add(new SqlParameter("@email", contato.Email));
                parameters.Add(new SqlParameter("@telefone", contato.Telefone));
                base.CommandInsert(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new InserirException("ContatoDAO",  ex);
            }
        }

        public DbDataReader FindByLikeObject(Contato contato)
        {
            try
            {
                sql = "";
                sql += "SELECT ";
                sql += "c.nome, c.sobre_nome, c.email, c.telefone ";
                sql += "FROM ";
                sql += "contatos c ";
                sql += "WHERE ";
                sql += "c.nome LIKE %@nome% AND ";
                sql += "c.sobre_nome LIKE %@sobre_nome% AND ";
                sql += "c.email LIKE %@email% AND ";
                sql += "c.telefone LIKE %@telefone%";
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@nome", contato.Nome));
                parameters.Add(new SqlParameter("@sobre_nome", contato.SobreNome));
                parameters.Add(new SqlParameter("@email", contato.Email));
                parameters.Add(new SqlParameter("@telefone", contato.Telefone));
                dbDataReader = base.CommandSelect(sql, parameters);
                if(dbDataReader.HasRows)
                    return dbDataReader;
            }
            catch (SqlException ex)
            {
                throw new InserirException("ContatoDAO", ex);
            }
            return null;
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
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}