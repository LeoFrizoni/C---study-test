using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class Curso
    {
        public string Nome { get; set; }//NOME DO CURSO
        public List<Pessoa> Alunos{ get; set; } //LISTA ALUNOS DO TIPO PESSOA

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados()//PARA UM METODO QUE NÃO É VOID FUNCIONAR, VOCÊ PRECISA DE UM RETURN
        {
            int Quantidade = Alunos.Count;
            return Quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);//RETORNA TRUE PARA REMOVE FEITO OU FALSE PARA NÃO FEITO
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            for(int count = 0; count < Alunos.Count; count++)//A VARIÁVEL COUNT SEMPRE COMEÇA POR 0
            {
                //string texto = "N° " + count + " - " + Alunos[count].NomeCompleto;//CONCATENAÇÃO USANDO O + (PARA TEXTO E STRING)
                string texto = $"N° {count+1} - {Alunos[count].NomeCompleto}";//INTERPOLAÇÃO  //COUNT + 1 PARA EVITAR QUE O PRIMEIRO ALUNO SEJA O NUMERO 0
                Console.WriteLine(texto);
                
            }
        }
    }
}