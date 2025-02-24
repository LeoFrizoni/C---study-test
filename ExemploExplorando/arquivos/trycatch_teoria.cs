//PARA LER O ARQUIVO arquivoLeitura.txt(TRY CATCH)
//try
//{
//   string[] linhas = File.ReadAllLines("Arquivos/arquivoLeituras.txt");
//   foreach(string linha in linhas)
//   {
//      Console.WriteLine(linha);
//   }
//}
//catch(FileNotFoundException ex)//EXCEÇÃO ESPECÍFICA
//{
//   Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
//}
//catch(DirectoryNotFoundException ex)
//{
//   Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
//}
//catch(Exception ex)//EXCEÇÃO GENÉRICA
//{
//   Console.WriteLine($"Ocorreu uma exceção Genérica: {ex.Message}");
//}
//finally
//{
//   Console.WriteLine($"Chegou até aqui. ")   
//}
