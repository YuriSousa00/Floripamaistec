namespace Exercicio3S4
{
    public class ContaEmpresarial : ContaBancaria
    {
        // Resposta exercício 03
        public ContaEmpresarial(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != EnumTipoPessoa.JURIDICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo Jurídico!");
            }
        }
    }
}
