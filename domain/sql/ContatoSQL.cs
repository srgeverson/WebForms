using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisContatos.domain.sql
{
    public class ContatoSQL
    {
        private string sql;
        public void createTable()
        {
            sql = "";
            sql += "CREATE TABLE contatos(";
            sql += "id int NOT NULL identity(1,1) primary key,";
            sql += "nome varchar(50) NULL,";
            sql += "sobre_nome varchar(50) NULL,";
            sql += " email varchar(50) NULL,";
            sql += " telefone varchar(20) NULL";
            sql += "); ";
        }
    }

}