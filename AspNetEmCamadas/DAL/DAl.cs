using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspNetEmCamadas
{
    public class DAL
    {
        //nome da connection String atraves da propriedade add
        static string connectionName = "ConexaoBanco";
        //propriedade global do sql 
        private SqlConnection connection;

        public DAL()
        {


            try
            {
                //buscando a string de conexao gerada atraves da aba gerenciador de servidores,em propriedade do banco
                //procurar por connectionString e adiciona-la ao webconfig

                string connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception)
            {

                throw new Exception("Conexao com o banco de dados nao funcionou");
            }

        }
        //metodo resposanvel listar os dados do banco
        //no asp.net conhecido como DataTable
        public DataTable RetDataTable(string sql)
        {
            //instancia do dataTable
            DataTable dataTable = new DataTable();
            //instancia e passagem de commando sql junto com a instancia de conexao
            SqlCommand command = new SqlCommand(sql, connection);

            //adapter responsavel por converter o comando passado por parametro em sql ou seja fazer uma adaptação
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            //metodo por preencher o datatable
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public void ExecuteCommandSql(string sql)
        {
            SqlCommand command = new SqlCommand(sql,connection);
            //Metodo ExecuteNonQuery utilizado para operaçãoes que nao retornam nada
            //como insert,update,delete
            command.ExecuteNonQuery();

        }

    }
}