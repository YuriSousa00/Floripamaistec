namespace M1S10_Projeto.Dto
{
    public class QuizCreateDto
    {
        public string Title { get; set; }
        public int IdDiscipline { get; set; }

    }
    public class QuizUpdateDto
    {
        public string Title { get; set; }
    }
    public class QuizReturnDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateOpen { get; set; }
        public DateTime DateClose { get; set; }
        public int IdDiscipline { get; set; }
    }
}
