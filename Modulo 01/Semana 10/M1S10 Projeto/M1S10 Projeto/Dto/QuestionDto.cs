namespace M1S10_Projeto.Dto
{
    public class QuestionCreateDto
    {
        public string Enunciation { get; set; }
        public decimal Weight { get; set; }
        public int IdQuiz { get; set; }
    }
    public class QuestionUpdateDto
    {
        public string Enunciation { get; set; }
        public decimal Weight { get; set; }
    }
    public class QuestionReturnDto
    {
        public int Id { get; set; }
        public string Enunciation { get; set; }
        public decimal Weight { get; set; }
        public int IdQuiz { get; set; }
    }
}
