//using ExemploFundamentos.Common.models;

//int[] arrayInteiros = new int[3];
//arrayInteiros[0] = 72;
//arrayInteiros[1] = 64;
//arrayInteiros[2] = 50;


//PERCORRENDO VALOR COM FOR//VOCÊ PRECISA DO VALOR DO CONTADOR

//for(int contador = 0; contador<arrayInteiros.Length; contador++)
//{
//    Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
//}


//PERCORRENDO VALOR COM FOREACH//VOCÊ NÃO PRECISA DO VALOR DO CONTADOR

//int contadorForeach = 0
//foreach(int valor in arrayInteiros)//PARA CADA VALOR INT NO ARRAY, O INT VIRA O ITEM DE VALOR
//{
//    Console.WriteLine($"Posição N° {contadorForeach} - {valor});
//    (COMO SE FOSSE
//     valor = 72;
//     valor = 64;
//     valor = 50;)
//    int contadorForeach++;  
//}


//COMO REDIMENSIONAR UM ARRAY

//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


//COPIAR UM ARRAY

//int[] arrayInteirosDobrado = new int[arrayInteiros.lenght * 2];
//Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);