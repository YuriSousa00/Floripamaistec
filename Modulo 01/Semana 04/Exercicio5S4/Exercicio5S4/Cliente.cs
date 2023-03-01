namespace Exercicio5S4
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string Profissao { get; private set; }
        public string EstadoCivil { get; private set; }
        public EnumTipoPessoa TipoPessoa { get; private set; }

        public Cliente(string nome, DateTime nascimento, string profissao, string estadoCivil, EnumTipoPessoa tipoPessoa)
        {
            this.Nome = nome;
            this.Nascimento = nascimento;
            this.Profissao = profissao;
            this.EstadoCivil = estadoCivil;
            this.TipoPessoa = tipoPessoa;
        }
    }
}
