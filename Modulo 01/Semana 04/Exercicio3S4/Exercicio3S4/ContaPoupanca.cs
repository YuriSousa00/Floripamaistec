namespace Exercicio3S4
{
    public class ContaPoupanca : ContaBancaria
    {
        // Resposta exercício 03
        public ContaPoupanca(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != EnumTipoPessoa.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo física!");
            }
        }
    }
}
