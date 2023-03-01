namespace Exercicio4S4
{
    public class ContaCorrente : ContaBancaria
    {
        // Resposta exercício 03
        public ContaCorrente(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != EnumTipoPessoa.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo física!");
            }
        }
    }
}
