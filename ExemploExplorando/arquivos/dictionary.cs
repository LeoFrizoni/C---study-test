//Dictionary<string, string> estados = new Dictionary<string, string>();//PRECISA DE DOIS TIPOS, PRIMEIRO PARA CHAVE E SEGUNDO PARA VALOR

//estados.Add("MG","Minas Gerais");
//estados.Add("SP","São Paulo");
//estados.Add("ES","Espírito Santo");

//foreach(KeyValuePair<string, string> item in estados)
//{
//      Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
//}

//estados.Remove("SP")//SEMPRE UTILIZA A CHAVE/KEY PARA OPERAÇÕES
//estados["MG"] = "Minas Gerais - Com Valor Alterado"

//Console.WriteLine(estados["MG"]);//PARA LER O VALOR DO DICTIONARY


//VERIFICANDO EXISTÊNCIA DE CHAVE
//string chave = "SP";
//Console.WriteLine($"Verificando existência do elemento: {chave}");

//if (estados.ContainsKey(chave))
//{
//      Console.WriteLine($"Valor de chave: {chave} já existente, impossível adicionar.");
//}
//else
//{
//      Console.WriteLine($"Valor de chave: {chave} inexistente, possível adicionar.");
//}