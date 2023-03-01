namespace Exercicio4S4
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
    }
}
