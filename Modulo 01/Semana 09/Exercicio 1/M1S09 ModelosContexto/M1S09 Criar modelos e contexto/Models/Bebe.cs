﻿namespace M1S09_Criar_modelos_e_contexto.Models
{
    public class Bebe
    {
        public int Id { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public decimal Peso_Nascimento { get; set; } 
        public int Altura { get; set; }
        public int Id_Mae { get; set; }
        public int Id_Parto { get; set; }

    }
}
