using System.Security.Cryptography.X509Certificates;
using ExemploFundamentos.Common.models;


//VARIÁVEIS

// //string apresentacao = "Olá, seja bem-vindo";
// //int quantidade = 1;
// //double altura = 1.80; casa decimal separada por ponto NAO REPRESENTA O 0
// //decimal preco = 27.90M;
// //bool condicao = true
// //Console.WriteLine(apresentacao);
// //Console.WriteLine("O valor da variável quantidade é:" +quantidade);
// //Console.WriteLine("O valor da variável altura é:" +altura.ToString("0.00"));
// //Console.WriteLine("O valor da variável preco é:" +preco);
// //Console.WriteLine("O valor da variável condicao é:" +condicao);
// // Pessoa pessoa1 = new Pessoa();
// // pessoa1.Nome = "Leo";
// // pessoa1.Age = 22;
// // pessoa1.Apresentar();
// // Pessoa _pessoa_FisicaRepresentacao = new Pessoa();
// // DateTime dataAtual = DateTime.Now;
// // Console.WriteLine(dataAtual);
// // Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
// // DateTime dataCincoDias = DateTime.Now.AddDays(5);
// // Console.WriteLine(dataCincoDias);


//CONVERSÃO

// // int a = 10;
// // int b = 20;
// // int c = a+b;
// // c += 5;// += -= /= *=
// // Console.WriteLine(c);
// //int d = Convert.ToInt32("5");//Cast - Casting
// //int d = int.Parse("5");
// //int d = Convert.ToInt32(null);//Trata valores nulos
// //int d = int.Parse(null);//Não trata valores nulos
// // int inteiro = 5;
// // string d = inteiro.ToString();//Para converter para String é específico
// // string e = "15-";
// // //int f = 0;
// // int.TryParse(e, out int f);//Caso não consiga converter o valor de E, ele retornará o valor de F no lugar(inicialmente 0 por padrão)
// // Console.WriteLine(b);
// // Console.WriteLine("Conversão realizada com Sucesso!");


//CONDICIONAL

// int quantidadeEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra >0 && quantidadeEstoque >= quantidadeCompra;//não existe compra negativa
// Console.WriteLine($"Quantidade em Esroque: {quantidadeEstoque}");
// Console.WriteLine($"A Quantidade de Compra é: {quantidadeCompra}");
// //Console.WriteLine($"É possível realizar a venda? {quantidadeEstoque >= quantidadeCompra}");//sem a var bool
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");
// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda Inválida.")
// }
// else if (possivelVenda)//if (quantidadeEstoque >= quantidadeCompra)
// {
//     Console.WriteLine("Venda realizada!");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
// }


//CONDICIONAIS COM SWITCH CASE

// Console.WriteLine("Digite uma Letra:");//DA MANEIRA TRABALHOSA
// string letra = Console.ReadLine();
// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é vogal.");
// }

// Console.WriteLine("Digite uma Letra:");//MANEIRA CONFUSA
// string letra = Console.ReadLine();
// if(letra == "a"|| //Sinal Pipe |
//    letra == "e"||
//    letra == "i"||
//    letra == "o"||
//    letra == "u")
// {
//     Console.WriteLine("É vogal");
// }
// else
// {
//     Console.WriteLine("Não é vogal.");
// }

// Console.WriteLine("Digite uma Letra:");//MELHOR MANEIRA
// string letra = Console.ReadLine();
// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("É uma vogal.");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal.");
//         break;
// }


//OPERADORES LÓGICOS

// bool ehMaiorDeIdade = true;//USANDO OR PIPE ||
// bool possuiAutorizacaoDoResponsavel = false;
// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada Liberada");
// }
// else
// {
//     Console.WriteLine("Entrada Proibida");
// }

// bool presencaMinima = true;//USANDO AND &&
// double media = 70.25;
// if(presencaMinima && media>=70)
// {
//     Console.WriteLine("Parabéns,você foi aprovado!");
// }
// else
// {
//     Console.WriteLine("Perdão pela notícia ruim, mas você foi reprovado.");
// }

// bool choveu = true;//USANDO O NOT ! 
// bool estaTarde = true;
// if(!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar.");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia.");
// }
