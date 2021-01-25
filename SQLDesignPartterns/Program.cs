using SQLDesignPartterns.modelo.carro;
using SQLDesignPartterns.modelo.carro.daoCarro;
using SQLDesignPartterns.modelo.daoPessoa;
using SQLDesignPartterns.modelo.pessoa;
using System;

namespace SQLDesignPartterns
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Pessoa joao = new Pessoa("joao",35);
            Pessoa joaquim = new Pessoa("joaquim",55);
            Pessoa manueal = new Pessoa("mauel",56);
            Pessoa.DaoPessoa.Adicionar(joaquim.GetParamentrosValores());
            Pessoa.DaoPessoa.Adicionar(manueal.GetParamentrosValores());
            Pessoa.DaoPessoa.Adicionar(joao.GetParamentrosValores());

        }
    }
}
