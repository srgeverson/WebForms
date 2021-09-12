using System;
using System.Data.SqlClient;
using System.Configuration;
using SisContatos.domain.exception;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;

namespace SisContatos.domain.dao
{
    public abstract class ConexaoDAO
    {
        private SqlCommand sqlCommand = null;
        private static string CONEXAO = ConfigurationManager.AppSettings["sqlConnection"];
        private SqlConnection sqlConnection = null;
        private DataTable dataTable = null;
        private SqlDataAdapter sqlDataAdapter = null;

        public void CommandInsert(string sql, List<SqlParameter> parameters)
        {
            try
            {
                using (sqlConnection = new SqlConnection(CONEXAO))
                {
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    foreach (SqlParameter sqlParameter in parameters)
                    {
                        sqlCommand.Parameters.Add(sqlParameter);
                    }
                    sqlCommand.Connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new InserirException("ConexaoDAO.CommandInsert", ex);
            }
            finally
            {
                sqlCommand.Connection.Close();
            }
        }

        public DataTable CommandSelect(string sql)
        {
            try
            {
                using (sqlConnection = new SqlConnection(CONEXAO))
                {
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlCommand.Connection.Open();
                    sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = sqlCommand;
                    dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                }
            }
            catch (SqlException ex)
            {
                throw new SelecioneException("ConexaoDAO.CommandSelect", ex);
            }
            return dataTable;
        }

        public void CommandUpdate(string sql, List<SqlParameter> parameters)
        {
            try
            {
                using (sqlConnection = new SqlConnection(CONEXAO))
                {
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    foreach (SqlParameter sqlParameter in parameters)
                    {
                        sqlCommand.Parameters.Add(sqlParameter);
                    }
                    sqlCommand.Connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new InserirException("ConexaoDAO.CommandUpdate", ex);
            }
            finally
            {
                sqlCommand.Connection.Close();
            }
        }
    }
}