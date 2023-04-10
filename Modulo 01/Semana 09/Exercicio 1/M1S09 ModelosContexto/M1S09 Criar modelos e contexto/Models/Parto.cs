namespace M1S09_Criar_modelos_e_contexto.Models
{
    public class Parto
    {
        public int Id { get; set; }
        public DateTime Data_Parto { get; set; }
        public DateTime Hora_Parto { get; set; }
        public int Id_Medico { get; set; }
    }
}
