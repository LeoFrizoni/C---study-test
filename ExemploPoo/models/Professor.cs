namespace ExemploPoo.models
{
    public class Professor : Pessoa //HERANÇA
    {
        public decimal Salario {get; set;}

        public override void Apresentar()//POLIMORFISMO
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um Professor que ganha {Salario}. ");
        }

    }
}