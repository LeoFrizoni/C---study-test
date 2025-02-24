
//(int ID,string Nome,string Sobrenome ,decimal Altura) tupla = (1, "Leonardo", "Frizoni", 1.80M); //ASSIM QUE SE DECLARA UMA TUPLA DECLARANDO NOME AO OBJETO

//ValueTuple <int, string, string, decimal> outroExemploTupla = (1, "Leonardo", "Frizoni", 1.80M);//DESSAS DUAS MANEIRAS NÃO SE PODER NOME OS OBJETOS
//var outroExemploTuplaCreate = Tupla.Create(1, "Leonardo", "Frizoni", 1.80M);//NAO PRECISA DECLARAR O TIPO, POIS O CREATE RECONHECE


//Console.WriteLine($"ID: {tupla.Item1}") -> int 1
//Console.WriteLine($"Nome: {tupla.Item2}") -> string Leonardo
//Console.WriteLine($"Sobrenome: {tupla.Item3}") -> string Frizoni
//Console.WriteLine($"Altura: {tupla.Item4}") -> decimal 1.80M

//LeituraArquivo arquivo = new LeituraArquivo();

//var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("arquivos/arquivoLeitura.txt");//PARA NAO UTILIZAR UMA VARIAVEL DEVE-SE TRATAR COMO (sucess0, _, _)
//if(sucesso)
//{
//   Console.WriteLine("Quantidade linhas do arquivo:" + quantidadeLinhas);
//   foreach(string linha in linhasArquivo)
//   {
//      Console.WriteLine(linha);
//   }     
//}
//else
//{
//   Console.WriteLine("Não foi possível ler o arquivo. ");
//}
