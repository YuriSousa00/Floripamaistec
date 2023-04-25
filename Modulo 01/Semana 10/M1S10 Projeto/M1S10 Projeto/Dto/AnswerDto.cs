namespace M1S10_Projeto.Dto
{
    public class AnswerCreateDto
    {
        public string Answers { get; set; }
        public string Observation { get; set; }
        public float Score { get; set; }
    }

    public class AnswerUpdateDto
    {
        public string Answers { get; set; }
        public string Observation { get; set; }
        public float Score { get; set; }

    }
    public class AnswerReturnDto
    {
        public int Id { get; set; }
        public string Answers { get; set; }
        public string Observation { get; set; }
        public float Score { get; set; }
        public int IdQuestion { get; set; }
        public int IdStudent { get; set; }
    }
}
