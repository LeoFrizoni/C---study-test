//OBJETO VENDA SERIALIZADO EM JSON

//DateTime dataAtual = DateTime.Now;
//List<Venda> listaVendas = new List<Venda>();//COLEÇÃO DE OBJETOS IGUAIS
//Venda v1 = new Venda(1, "Material de Escritório", 25.00M, dataAtual);
//Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);//DATA PADRONIZADA DE ACORDO COM A ISO 8601

//listaVendas.Add(v1);
//listaVendas.Add(v2);
//string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
//File.WriteAllText("arquivos/vendas.json", serializado); //CRIANDO UM ARQUIVO COM A LISTA DE OBJETO SERIALIZADO
//Console.WriteLine(serializado);


//DESERIALIZE

//string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
//List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Vendas>>(conteudoArquivo);
//foreach(Venda venda in listaVenda)
//{
//  Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" +
//            $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
//}
