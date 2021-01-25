using SQLDesignPartterns.modelo.daoPessoa;
using SQLDesignPartterns.sql.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLDesignPartterns.modelo.pessoa
{
    class Pessoa : Itabela
    {
        private string nome;
        private int idade;
        private static DaoPessoa daoPessoa;
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            daoPessoa = new DaoPessoa("pessoa", this);
        }

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        internal static DaoPessoa DaoPessoa { get => daoPessoa; set => daoPessoa = value; }

        public List<string> GetColuna()
        {
            List<string> l = new List<string>();
            l.Add("nome varchar(30)");
            l.Add("idade int");
            return l;
        }

        public Dictionary<string, object> GetParamentrosValores()
        {
            Dictionary<string, object> parametrosValores = new Dictionary<string, object>();
            parametrosValores.Add("@nome", nome);
            parametrosValores.Add("@idade", idade);
            return parametrosValores;
        }
    }
}
