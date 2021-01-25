using SQLDesignPartterns.sql.conecao;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLDesignPartterns.sql.dao
{
    abstract class DAO
    {
        protected string nomeTabela;
        private List<string> nomeColunas;
        private Conexao conexao = new Conexao();
        public string query{get; set;}
        public DAO(string nomeTabela, List<string> nomeColunas)
        {
            Tabela(nomeTabela, nomeColunas);
            this.nomeColunas = nomeColunas;
            //this.conexao = conexao;
        }
        public void Tabela(string nomeTabela, List<string> nomesColunas)
        {
            conexao.Abrir();
            string colunas=ColunasBuider(nomesColunas);
            //query = "IF NOT EXISTS (SELECT * FROM sysobjects WHERE NAME=" +nomeTabela+ " and xtype='U') " +
            //    "CREATE TABLE " + nomeTabela+ "( "+colunas+" )";
            query = " IF NOT EXISTS(SELECT* FROM sysobjects WHERE name= "+"'"+nomeTabela+"'"+" and xtype = 'U')" +
                     " CREATE TABLE "+nomeTabela+"("+colunas+")";
            conexao.ExecQuery(query);
            conexao.Fechar();
            this.nomeTabela = nomeTabela;
        }

        private string ColunasBuider(List<string> nomesColunas)
        {
            string colunas= "ID INT IDENTITY(1,1) PRIMARY KEY";
            foreach(string i in nomesColunas)
            {
                colunas = colunas + "," + i;
            }
            return colunas;
        }

        public string Adicionar(Dictionary<string,object> d)
        {
            string colunas=null;
            string colunasValores=null;
            string sss;
            int index = nomeColunas.Count;
            foreach (string s in nomeColunas)
            {
                
                char[] ss = s.ToCharArray();
                sss = null;
                for (int i=0; i< ss.Length; i++)
                {
                    
                    if (ss[i].Equals(' '))
                        break;
                    sss = sss + ss[i];
                }
                
                colunas = colunas + sss ;
                colunasValores = colunasValores + "@" + sss ;
                
                if (index>1)
                {
                    colunas = colunas + ",";
                    colunasValores = colunasValores + ",";
                }
                index--;

            }
            conexao.Abrir();
            string sql = "INSERT INTO " + nomeTabela + "(" + colunas + ")" + " VALUES" + "(" + colunasValores + ")";
            conexao.ExecQuery(sql,nomeColunas, d);
            conexao.Fechar();
            return sql;
        }
        public void Deletar(Object ob)
        {
            
        }
        public Object Selecionar()
        {
            return new Object();
        }
        public List<Object> Query()
        {
            return new List<object>();
        }
    }
}
