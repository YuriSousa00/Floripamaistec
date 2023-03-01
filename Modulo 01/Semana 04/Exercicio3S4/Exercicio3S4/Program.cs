using Exercicio3S4;

Cliente pessoaFisica = new Cliente("Bruno Costa", DateTime.Parse("1999-01-25"), "Desenvolvedor", "Casado", EnumTipoPessoa.FISICA);

Cliente pessoaJuridica = new Cliente("Bruno Costa", DateTime.Parse("1999-01-25"), "Desenvolvedor", "Casado", EnumTipoPessoa.JURIDICA);

ContaEmpresarial contaJuridica = new ContaEmpresarial(1542, 1234, pessoaJuridica);

ContaCorrente contaCorrente = new ContaCorrente(1542, 1234, pessoaFisica);

ContaPoupanca contaPoupanca = new ContaPoupanca(1542, 1234, pessoaFisica);