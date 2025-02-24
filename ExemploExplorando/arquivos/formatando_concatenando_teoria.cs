//using System.Globalization;

//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo ("en-US");//PARA MUDAR A LOCALIZAÇÃO DO SISTEMA
//decimal valorMonetario = 82.40M;
//Console.WriteLine($"{valorMonetario:C}");//o : é o comando pra formatar e o C é currency, o C puxa os dados da localização e da cultura do sistema
//Console.WriteLine(valorMonetario.toString("C",CultureInfo.CreateSpecificCulture("en-US")));//PARA FORMATAR EM OUTRO SISTEMA SÓ NO FINAL


//double porcentagem = .3421
//Console.WriteLine(porcentagem.ToString("P"));
//RETORNA 34,21%


//int numero = 123456
//Console.WriteLine(numero.ToString("##-##-##"));
//RETORNA 12-34-56


//DateTime data = DateTime.Now;
//DateTime data = DateTime.Parse("17/04/2022 18:00")
//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); se colocar MM ele representa dois digitos, se for M ele representa um digito
//Console.WriteLine(data.ToShortDataString()); para apresentar apenas a Data sem hora
//Console.WriteLine(data.ToShortTimeString()); para apresentar apenas a hora


//CONVERSAO SEGURA DE DATA COM TRYPARSE EXACT(bool)
//string dataString = "2022-13-17 18:00" MES 13 INVÁLIDO
//bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimetyles.None, out DateTime data);
//if (sucesso)
//{
//    Console.WriteLine($"Conversão com sucesso: {data}");
//}
//else
//{
//    Console.WriteLine($"{dataString} não é uma data válida.");
//}

//Console.WriteLine(data)
//ELE VAI RETORNAR 01/01/0001 00:00:00 SE NÃO TIVER IF