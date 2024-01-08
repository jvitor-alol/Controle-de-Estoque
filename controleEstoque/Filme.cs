using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque
{
    public class Filme
    {
        private string? nome;
        private int id;
        private int quantidade;
        private double preco;
        private int ano;
        private string? classificacao;
        private int duracao;

        const int anoPrimeiroFilme = 1906;
        internal int anoAtual = DateTime.Now.Year;
        const double precoMin = 0.01, precoMax = 999.99;
        const int duracaoMin = 1, duracaoMax = 271;

        public Filme (string? aNome, int aID, int aQuantidade, double aPreco, int aAno, string? aClassificacao, int aDuracao)
        {
            Nome = aNome;
            ID = aID;
            Quantidade = aQuantidade;
            Preco = aPreco;
            Ano = aAno;
            Classificacao = aClassificacao;
            Duracao = aDuracao;
        }
        
        public string? Nome
        {
            get {return nome;}
            set 
            {
                if (value!=null){
                    nome = value;
                }
            }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string? Classificacao 
        { 
            get { return classificacao; } 
            set 
            {
                if (value == "L" || value == "10" || value == "12" || value == "14" || value == "16" || value == "18")
                {
                    classificacao = value;
                }
                else
                    classificacao = "18";
            } 
        }

        public int Quantidade
        {
            get { return quantidade; }
            set
            {
                if (value > 0)
                    quantidade = value;
                else
                    quantidade = 0;
            }
        }

        public double Preco
        {
            get { return preco; }
            set
            {
                if (value < precoMin)
                    preco = precoMin;
                else if (value > precoMax)
                    preco = precoMax;
                else
                    preco = value;
            }
        }

        public int Ano
        {
            get { return ano; }
            set
            {
                if (value < anoPrimeiroFilme)
                    ano = anoPrimeiroFilme;
                else if (value > anoAtual)
                    ano = anoAtual;
                else 
                    ano = value;
            }
        }

        public int Duracao
        {
            get { return duracao; }
            set
            {
                if (value < duracaoMin)
                    duracao = duracaoMin;
                else if (value > duracaoMax)
                    duracao = duracaoMax;
                else
                    duracao = value;

            }

        } 
    }
}
