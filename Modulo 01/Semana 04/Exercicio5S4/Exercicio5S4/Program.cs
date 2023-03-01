using Exercicio5S4;

Cliente pessoaFisica = new Cliente("Bruno Costa", DateTime.Parse("1999-01-25"), "Desenvolvedor", "Casado", EnumTipoPessoa.FISICA);

Cliente pessoaJuridica = new Cliente("Bruno Costa", DateTime.Parse("1999-01-25"), "Desenvolvedor", "Casado", EnumTipoPessoa.JURIDICA);

ContaEmpresarial contaJuridica = new ContaEmpresarial(1542, 1234, pessoaJuridica, 1500, 10, "0452824100001");

contaJuridica.FazerEmprestimo(1200);
contaJuridica.Depositar(200);
contaJuridica.ExibirSaldo();
contaJuridica.PagarEmprestimo();
contaJuridica.ExibirSaldo();

ContaCorrente contaCorrente = new ContaCorrente(1542, 1234, pessoaFisica);

contaCorrente.Depositar(200);
contaCorrente.Sacar(50);
contaCorrente.ExibirSaldo();


ContaPoupanca contaPoupanca = new ContaPoupanca(1542, 1234, pessoaFisica);