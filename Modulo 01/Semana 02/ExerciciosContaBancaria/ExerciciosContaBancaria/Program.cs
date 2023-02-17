using ExerciciosContaBancaria.Classes;

ContaBancaria conta = new ContaBancaria();

conta.numero = 2223;
conta.agencia = 9999;
conta.nomeDoTitular = "Yuri Sousa";
conta.tipoConta = enumContaBancaria.CORRENTE;

conta.Depositar(100);

conta.Sacar(50);

conta.ExibirSaldo();

