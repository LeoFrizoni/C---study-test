using ExemploExplorando.models;
using Newtonsoft.Json;

//DECONSTRUCT

//Pessoa p1 = new Pessoa("Leonardo", "Buta");//JUNTOU AS DUAS VARIAVEIS EM UMA SÓ
//(string nome, string sobrenome) = p1;
//Console.WriteLine($"{nome} {sobrenome}");//ELE PEGA AS DUAS STRINGS E SEPARA ELAS EM DUAS VARIAVEIS NOVAMENTE

Pessoa p1 = new Pessoa();
Console.WriteLine("Digite Nome do aluno: ");
p1.Nome = Console.ReadLine();//o = representa o Set
Console.WriteLine("Digite Sobrenome do aluno: ");
p1.Sobrenome = Console.ReadLine();
//Console.WriteLine("Digite Idade do aluno: ");
//p1.Idade = int.Parse(Console.ReadLine());
p1.Apresentar();

Pessoa p2 = new Pessoa();//CONSTRUTOR VAZIO
p2.Nome = "Laís";
p2.Sobrenome = "Frizoni Lawall";

Pessoa p3 = new Pessoa(nome: "Bruna",sobrenome: "Aimée Matoso");//CONSTRUTOR COM VALORES

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();
