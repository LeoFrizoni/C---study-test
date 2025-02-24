using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//PROPRIEDADES CLASSE PESSOA: Nome, Sobrenome, Idade
namespace ExemploExplorando.models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa (string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
        private string _nome;//ENCAPSULAMENTO PARA VALIDAÇÃO
        private int _idade;
        public string Nome 
        { 
            get => _nome.ToUpper();//BODY EXPRESSION, UMA MANEIRA MAIS SIMPLES ao invés de Return _nome.ToUpper

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }

                _nome = value; 
            } 
        }//GET = obtendo valor que você armazenou
        
        public string Sobrenome { get; set; }//PROP APENAS LEITURA

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();//COMBINAÇÃO DE PROPRIEDADE APENAS GET
        
        public int Idade 
        { 
            get => _idade;

            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("A idade não pode ser igual ou menor que zero");
                }

                _idade = value;
            } 
        }//SET = você atribui um valor
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto} e Idade: {Idade}");//Representa o GET
            //O $ REPRESENTA INTERPOLAÇÃO 
        }


    }
}