namespace TratExcRegraDeNegocio
{
    public class Evento
    { 
        int qtdLugares;
        int qtdIngressosVendidos;

        public Evento()
        {
        }
        public int QtdLugares { get; set; }
        public int QtdIngressosVendidos { get; set; }
        public void ingressoVendido()
        {
            Console.WriteLine("Ingresso vendido com sucesso!");
        }
    }
}