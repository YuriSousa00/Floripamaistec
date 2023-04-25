using FluentValidation;
using M1S10_Projeto.Models;

namespace M1S10_Projeto.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.Email).EmailAddress().NotNull().Length(1, 20).NotEmpty();
            RuleFor(x => x.Name).NotEmpty().NotNull().Length(1, 40);
            RuleFor(x => x.Password).NotEmpty().NotNull().Length(1, 11).Matches("[0-9]").WithMessage("A senha deve conter pelo menos um número");
            RuleFor(x => x.CPF).NotNull().NotEmpty();
        }
    }
}
