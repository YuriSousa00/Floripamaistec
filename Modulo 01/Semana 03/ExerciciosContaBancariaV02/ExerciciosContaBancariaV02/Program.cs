using ExerciciosContaBancariaV02.Classes;

ContaBancariaV02 conta1 = new ContaBancariaV02(1542, 1234, "Bruno Costa", enumContaBancariaV02.POUPANCA);
ContaBancariaV02 conta2 = new ContaBancariaV02(1545, 1234, "Breno Costa", enumContaBancariaV02.CORRENTE);



conta1.Depositar(200);

conta1.Transferir(conta2, 50);

conta1.ExibirSaldo();
//Deve retornar 150
conta2.ExibirSaldo();
//Deve retornar 50