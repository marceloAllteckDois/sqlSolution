using SQLDesignPartterns.sql.conecao;
using SQLDesignPartterns.sql.dao;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLDesignPartterns.modelo.carro.daoCarro
{
    class DaoCarro : DAO
    {
        public DaoCarro(string tabela, Carro carro):base(tabela,carro.GetColuna())
        {
            
        }
      
    }
}
