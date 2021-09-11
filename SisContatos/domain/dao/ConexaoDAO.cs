using System;
using System.Data.SqlClient;
using System.Configuration;
using SisContatos.domain.exception;
using System.Collections.Generic;

namespace SisContatos.domain.dao
{
    /// <summary>
    /// Classe responsavel por executar os comandos e conter a conexao com o banco de dados.
    /// </summary>
    public abstract class ConexaoDAO
    {
        private SqlCommand sqlCommand = null;
        private SqlConnection sqlConnection = null;
        private SqlDataReader sqlDataReader = null;
        private static string CONEXAO = ConfigurationManager.AppSettings["sqlConnection"];

        /// <summary>
        /// Metodo responsavel por executar o script de insert no banco de dados.
        /// </summary>
        /// <param name="queryString">
        /// Comando SQL de insercao
        /// </param>
        public void CommandInsert(string queryString)
        {
            try
            {
                using (sqlConnection = new SqlConnection(CONEXAO))
                {
                    sqlCommand = new SqlCommand(queryString, sqlConnection);
                    sqlCommand.Connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new InserirException("ConexaoDAO", ex);
            }
            finally
            {
                sqlCommand.Connection.Close();
            }
        }

        /// <summary>
        /// Metodo responsavel por executar o script de insert no banco de dados.
        /// </summary>
        /// <param name="queryString">
        /// Comando SQL de insercao
        /// </param>
        public void CommandInsert(string queryString, List<SqlParameter> parameters)
        {
            try
            {
                using (sqlConnection = new SqlConnection(CONEXAO))
                {
                    sqlCommand = new SqlCommand(queryString, sqlConnection);
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
                throw new InserirException("ConexaoDAO", ex);
            }
            finally
            {
                sqlCommand.Connection.Close();
            }
        }

        /// <summary>
        /// Metodo responsavel por executar o script de select no banco de dados.
        /// </summary>
        /// <param name="queryString">
        /// Comando SQL de selecao
        /// </param>
        /// <param name="parameters">
        /// Lista de parametros
        /// </param>
        public SqlDataReader CommandSelect(string queryString, List<SqlParameter> parameters)
        {
            try
            {
                using (sqlConnection = new SqlConnection(CONEXAO))
                {
                    sqlCommand = new SqlCommand(queryString, sqlConnection);
                    foreach (SqlParameter sqlParameter in parameters)
                    {
                        sqlCommand.Parameters.Add(sqlParameter);
                    }
                    sqlCommand.Connection.Open();
                    sqlDataReader = sqlCommand.ExecuteReader();
                }
            }
            catch (SqlException ex)
            {
                throw new SelecioneException("ConexaoDAO", ex);
            }
            finally
            {
                sqlCommand.Connection.Close();
            }
            return sqlDataReader;
        }
    }
}