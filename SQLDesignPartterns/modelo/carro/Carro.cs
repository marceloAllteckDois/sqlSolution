using SQLDesignPartterns.sql.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLDesignPartterns.modelo.carro
{
    class Carro : Itabela
    {
        string nome;
        string cor;
        int ano;

        public Carro(string nome, string cor, int ano)
        {
            this.nome = nome;
            this.cor = cor;
            this.ano = ano;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cor { get => cor; set => cor = value; }
        public int Ano { get => ano; set => ano = value; }

        public List<string> GetColuna()
        {
            List<string> l = new List<string>();
            l.Add("nome varchar(30)");
            l.Add("cor varchar(20)");
            l.Add("ano int");
            return l;
        }

        public Dictionary<string, object> GetParamentrosValores()
        {
            Dictionary<string, object> parametrosValores = new Dictionary<string, object>();
            parametrosValores.Add("nome", nome);
            parametrosValores.Add("cor", cor);
            parametrosValores.Add("ano", ano);
            return parametrosValores;
        }
    }
}
