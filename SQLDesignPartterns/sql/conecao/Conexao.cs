using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Collections;

namespace SQLDesignPartterns.sql.conecao
{
    class Conexao 
    {
        private SqlConnection connection;
        private SqlCommand command;
        public Conexao() 
        {
            string depoisMuda = @"Data Source=DESKTOP-2N2M9PU; Initial Catalog=TestePessoa; User ID=DESKTOP-2N2M9PU\eu; Integrated Security=SSPI;";
            connection = new SqlConnection(depoisMuda);
            command = new SqlCommand();
        }
        public void Fechar()
        {
            connection.Close();
        }
        public bool Abrir()
        {
            connection.Open();
            return false;
        }
        public void ExecQuery(string query)
        {
            comando(query);
        }
        public void ExecQuery(string query, ArrayList lista)
        {
            comando(query);
        }
        public void ExecQuery(string query, List<string> nomeColunas,Dictionary<string, object> d)
        {
            
            foreach (KeyValuePair<string,object> pair in d)
            {
                command.Parameters.AddWithValue(pair.Key,pair.Value);
            }
            comando(query);

        }

        private void comando(string query)
        {
            command.Connection = connection;
            command.CommandText = query;
            command.ExecuteNonQuery();
            command.CommandText = "";
            command.Dispose();
        }
    }
}
