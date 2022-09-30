using FluentValidation;
using YukselenWebAPI.ViewModel;

namespace YukselenWebAPI.Validators
{
    public class UserValidation_Form : AbstractValidator<VM_User_Form>
    {
        public UserValidation_Form()
        {
            RuleFor(u => u.Name)
                .NotNull()
                .MaximumLength(50)
                .MinimumLength(3);

            RuleFor(u => u.Email)
                .NotNull()
                .EmailAddress();

            RuleFor(u => u.PhoneNumber)
                .NotNull()
                .Length(11);

            RuleFor(u => u.UserLength)
                .NotNull()
                .InclusiveBetween(130, 230);


            RuleFor(u => u.UserKilo)
                .NotNull()
                .InclusiveBetween(40, 150);

            RuleFor(u => u.Gender)
                .NotNull()
                .Length(5);

            RuleFor(d => d.Day)
                .NotNull()
                .InclusiveBetween(1, 32);

            RuleFor(m => m.Months)
                .NotNull()
                .InclusiveBetween(1, 13);

            RuleFor(y => y.Year)
                .NotNull()
                .InclusiveBetween(1919, 2008);
        }
    }
}
