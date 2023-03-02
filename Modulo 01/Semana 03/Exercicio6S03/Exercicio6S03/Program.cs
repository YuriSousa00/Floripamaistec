using Exercicio6S03;

Produto produto1 = new Produto();

produto1.Nome = "Calculadora";
produto1.verificarEstoque();

Console.WriteLine("O nome de produto é: " + produto1.Nome);

ProdutoFinanceiro classeFilha= new ProdutoFinanceiro();

classeFilha.Nome = "Produto Financeiro";
classeFilha.verificarEstoque();
classeFilha.acesso();