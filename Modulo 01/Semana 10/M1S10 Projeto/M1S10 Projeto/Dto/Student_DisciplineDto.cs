namespace M1S10_Projeto.Dto
{
    public class Student_DisciplineCreateDto
    {
        public int IdStudent { get; set; }
        public int IdDiscipline { get; set; }
    }
    public class Student_DisciplineUpdateDto
    {
        public int IdDiscipline { get; set; }
    }
    public class Student_DisciplineReturnDto
    {
        public int Id { get; set; }
        public int IdStudent { get; set; }
        public int IdDiscipline { get; set;  }
    }
}

