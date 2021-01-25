using SQLDesignPartterns.modelo.pessoa;
using SQLDesignPartterns.sql.conecao;
using SQLDesignPartterns.sql.dao;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLDesignPartterns.modelo.daoPessoa
{
    class DaoPessoa : DAO
    {
        const string TABELA = "pessoa";
        


        public DaoPessoa(string tabela,Pessoa pessoa):base(tabela,pessoa.GetColuna())
        {
            
        }
        public DaoPessoa(Pessoa pessoa):base(TABELA,pessoa.GetColuna())
        {
        }
    }
}
