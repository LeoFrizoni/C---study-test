using System.Security.Cryptography.X509Certificates;
using ExemploFundamentos.Common.models;


//FOR

//int numero = 2;
//for(int contador = 0; contador <= 10000; contador++)
//{
//    Console.WriteLine($"{numero} * {contador} = {numero * contador}");
//}


//WHILE(Pode acabar em um looping infinito, tomar cuidado)

//int numero = 5;
//int contador = 0;

//while(contador <= 100)
//{
//    Console.WriteLine($"{contador + 1}Execução°: {numero} * {contador} = {numero * contador}");//Começa a contar da primeira execução
//    contador++;
//    if (contador == 80)//O BREAK TEM PREFERÊNCIA DENTRO DE UMA EXECUÇÃO
//   {
//     break;
//   }      
//}


//DO WHILE

//int soma = 0, numero = 0;
//do 
//{
//    Console.WriteLine("Digite um número (0 para parar)");
//    numero = Convert.ToInt32(Console.ReadLine());
//    soma += numero;
//} while(numero != 0);//PARA QUANDO O 0 É DIGITADO
//Console.WriteLine($"Total da soma dos números digitados é: {soma} ");