using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M1S10_Projeto.Models
{
    public class Student : User
    {
        public int Period { get; set; }
        public int RA { get; set; }
        public int IdUser { get; set; }
      

    }
}
