using Exercicio1S3;

Produto produto1 = new Produto("Calculadora", 5.75, 199);
Produto produto2 = new Produto();

Console.WriteLine($"O produto1 tem nome: {produto1.nome}, valor: {produto1.preco}, Quantidade: {produto1.quantidade}");
Console.WriteLine($"O produto1 tem nome: {produto2.nome}, valor: {produto2.preco}, Quantidade: {produto2.quantidade}");