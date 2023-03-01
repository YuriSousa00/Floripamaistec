namespace Exercicio5S4
{
    public class ContaEmpresarial : ContaBancaria
    {
        // Resposta exercpicio 04
        public decimal LimiteEmprestimo { get; private set; }
        public decimal TaxaJuros { get; private set; }
        public decimal ValorUsado { get; private set; }
        public bool PossuiEmprestimo { get; private set; }
        public string CNPJ { get; private set; }

        // Resposta exercício 03
        public ContaEmpresarial(int numero, int agencia, Cliente cliente, decimal limiteEmprestimo, decimal taxaJuros, string cnpj) : base(numero, agencia, cliente)
        {
            // Resposta exercpicio 04
            LimiteEmprestimo = limiteEmprestimo;
            TaxaJuros = taxaJuros;
            CNPJ = cnpj;

            if (cliente.TipoPessoa != EnumTipoPessoa.JURIDICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo Jurídico!");
            }
        }
        // Resposta exercício 05
        public void FazerEmprestimo(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0!");
                return;
            }

            if (PossuiEmprestimo)
            {
                Console.WriteLine("Você já possui um empréstimo ativo!");
                return;
            }

            if (valor > LimiteEmprestimo)
            {
                Console.WriteLine("O valor ultrapassa seu limite de empréstimo disponível!");
                return;
            }

            PossuiEmprestimo = true;
            base.Depositar(valor);
            ValorUsado = valor;
            Console.WriteLine($"Empréstimo no valor de R$ {valor} realizado com sucesso!");
        }

        // Resposta exercício 05
        public void PagarEmprestimo()
        {
            decimal total = ValorUsado + (ValorUsado * TaxaJuros / 100);
            if (total > Saldo)
            {
                Console.WriteLine("Você não tem saldo suficiente para realizar o pagamento!");
                return;
            }

            Sacar(total);
            PossuiEmprestimo = false;
            ValorUsado = 0;
            Console.WriteLine($"Empréstimo no valor total de R$ {total} pago com sucesso!");
        }
    }
}
