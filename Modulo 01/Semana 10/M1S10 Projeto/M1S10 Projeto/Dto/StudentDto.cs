using M1S10_Projeto.Models;

namespace M1S10_Projeto.Dto
{
    public class StudentUpdateDto 
    { 
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? CPF { get; set; }
        public string? Password { get; set; }
    }

    public class StudentCreateDto
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? CPF { get; set; }
        public string? Password { get; set; }
    }

    public class StudentReturnDto
    {
        public int? RA { get; set; }
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string CPF { get; set; }
        public string? Password { get; set; }
        
    }
}
