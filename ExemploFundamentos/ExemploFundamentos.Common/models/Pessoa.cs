using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Uma model representa um modelo para um objeto, como se fosse uma planta de uma casa e não a casa em si*/

namespace ExemploFundamentos.Common.models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Age { get; set; }
        public string? NomeRepresentanteLegalDaPessoaFísica { get; set; }

        public void Apresentar()
        { 
            /*Console.WriteLine($"Olá, meu nome é " +
            "{Nome}, e tenho {Age} anos.");*/ /*Serve apenas para organização*/
            Console.WriteLine($"Olá, meu nome é {Nome}, \n e tenho {Age} anos.");
        }
    }
}