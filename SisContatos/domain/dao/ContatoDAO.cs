using System;
using System.Data.SqlClient;
using SisContatos.domain.model;
using SisContatos.domain.exception;
using System.Collections.Generic;
using System.Data.Common;
using SisContatos.domain.service;
using System.Data;

namespace SisContatos.domain.dao
{
    public class ContatoDAO : ConexaoDAO, IContatoService
    {
        private string sql;
        private DataTable dataTable = null;
        private List<Contato> contatos = null;
        private Contato contato = null;
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

        Contato IContatoService.Buscar(int id)
        {
            try
            {
                sql = "";
                sql += "SELECT ";
                sql += "c.id, c.nome, c.sobre_nome, c.email, c.telefone ";
                sql += "FROM ";
                sql += "contatos c ";
                sql += "WHERE ";
                sql += "c.id = '" + id + "'";
                dataTable = base.CommandSelect(sql);
                if (dataTable.Rows.Count == 1)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        contato = new Contato();
                        contato.Id = Int32.Parse(row["id"].ToString());
                        contato.Nome = row["nome"].ToString();
                        contato.SobreNome = row["sobre_nome"].ToString();
                        contato.Email = row["email"].ToString();
                        contato.Telefone = row["telefone"].ToString();

                    }
                    return contato;
                }
            }
            catch (SqlException ex)
            {
                throw new SelecioneException("ContatoDAO", ex);
            }
            return null;
        }

        List<Contato> IContatoService.Listar(Contato contato)
        {
            try
            {
                sql = "";
                sql += "SELECT ";
                sql += "c.id, c.nome, c.sobre_nome, c.email, c.telefone ";
                sql += "FROM ";
                sql += "contatos c ";
                sql += "WHERE ";
                if (contato.Id == 0)
                {
                    sql += "c.id LIKE '%%' AND ";
                }
                else
                {
                    sql += "c.id LIKE '%" + contato.Id + "%' AND ";
                }
                sql += "c.nome LIKE '%" + contato.Nome + "%' AND ";
                sql += "c.sobre_nome LIKE '%" + contato.SobreNome + "%' AND ";
                sql += "c.email LIKE '%" + contato.Email + "%' AND ";
                sql += "c.telefone LIKE '%" + contato.Telefone + "%'";
                dataTable = base.CommandSelect(sql);
                contatos = new List<Contato>();
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var c = new Contato();
                        c.Id = Int32.Parse(row["id"].ToString());
                        c.Nome = row["nome"].ToString();
                        c.SobreNome = row["sobre_nome"].ToString();
                        c.Email = row["email"].ToString();
                        c.Telefone = row["telefone"].ToString();
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