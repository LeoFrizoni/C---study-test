using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//TUPLA EM MÉTODOS
namespace ExemploExplorando.models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)//DEFINIMOS UMA TUPLA PARA UM RETORNO TRIPLO
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());//EM CASO DE SUCESSO
            }
            catch(Exception)
            {
                return(false, new string[0], 0);
            }
        }
    }
}