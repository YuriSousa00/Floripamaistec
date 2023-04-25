using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace M1S10_Projeto.Models
{
    public class Teacher : User
    {
        public string Departament { get; set; }
        public int IdUser { get; set;}


    }
}
