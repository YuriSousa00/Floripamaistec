namespace M1S10_Projeto.Dto
{
    public class DisciplineCreateDto
    {
        public string Disciplines { get; set; }
        public int IdTeacher { get; set; }
    }

    public class DisciplineUpdateDto
    {
        public string Disciplines { get; set; }

    }
    public class DisciplineReturnDto
    {
        public int Id { get; set; }
        public string Disciplines { get; set; }
        public int IdTeacher { get; set; }
    }
}


