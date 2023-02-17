namespace ExerciciosContaBancaria.Classes
{
    public class ContaBancaria
    {
        //Resposta Exercicio 03
        public int numero;
        public int agencia;
        public string nomeDoTitular;
        public decimal saldo = 0;
        public enumContaBancaria tipoConta;

        //Respostas exercicio 4
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior que 0");
            } else
            {
                saldo += valor;
            }
        }
        //Resposta Exercicio 5
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior que 0");

            } else if (valor > saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo atual.");

            } else
            {
                saldo -= valor;
            }
        }
        //Resposta exercicio 6
        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {saldo}");
        }
    }
}