using System;
using System.Data.SqlClient;
using SisContatos.domain.model;
using SisContatos.domain.exception;
using System.Collections.Generic;
using System.Data.Common;
using SisContatos.domain.service;

namespace SisContatos.domain.dao
{
    public class ContatoDAO : ConexaoDAO, IContatoService
    {
        private string sql;
        private DbDataReader dbDataReader = null;
        private List<Contato> contatos = null;
        void IContatoService.Adicionar(Contato contato)
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
                throw new InserirException("ContatoDAO", ex);
            }
        }

        List<Contato> IContatoService.Listar(Contato contato)
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
                if (dbDataReader.HasRows)
                {
                    foreach(Contato c in dbDataReader)
                    {
                        c.Id = Int32.Parse(dbDataReader["id"].ToString());
                        c.Nome = dbDataReader["nome"].ToString();
                        c.SobreNome = dbDataReader["sobre_nome"].ToString();
                        c.Email = dbDataReader["email"].ToString();
                        c.Telefone = dbDataReader["telefone"].ToString();
                        contatos.Add(c);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new SelecioneException("ContatoDAO", ex);
            }
            return contatos;
        }
    }
}